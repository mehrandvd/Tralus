using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.XtraPrinting.Native;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppViewControllertopic.
    public abstract partial class TralusEntitySimpleViewController<TEntity> : TralusViewControllerBase where TEntity : EntityBase
    {
        private SimpleAction _tralusSimpleAction;

        protected TralusEntitySimpleViewController()
        {
            InitializeComponent();
            InitializeAction();
        }

        public void InitializeAction()
        {
            _tralusSimpleAction = new SimpleAction(components)
            {
                Id = GetType().ToString(),
            };

            TargetObjectType = _tralusSimpleAction.TargetObjectType = typeof(TEntity);
            TypeOfView = _tralusSimpleAction.TypeOfView = IsMultipleExecutionSupported ? typeof(View) : typeof(DetailView);
            
            _tralusSimpleAction.Execute += tralusSimpleAction_Execute;
            
            Actions.Add(_tralusSimpleAction);
        }

        private void AfterExecute()
        {
            OnAfterExecute();
        }

        protected virtual void OnAfterExecute()
        {


        }


        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            if (IsDetailMode())
            {
                var detailView = GetDetailView();

                SetCanExecuteRules(SelectedObject, detailView);
                
                detailView.ObjectSpace.ModifiedChanged += ObjectSpaceOnModifiedChanged;

                detailView.ViewEditModeChanged += (sender, args) => SetCanExecuteRules(SelectedObject, detailView);
            }
            else if (IsListMode() && IsMultipleExecutionSupported)
            {
                Action<IEnumerable<TEntity>> canExecuteOnSelectedObjects =
                    selectedObjects => _tralusSimpleAction.Enabled.SetItemValue("CanExecute must be true for all", CanExecute(selectedObjects));

                canExecuteOnSelectedObjects(SelectedObjects);

                var listView = GetListView();
                listView.SelectionChanged += (sender, args) => canExecuteOnSelectedObjects(SelectedObjects);
            }
        }

        private void SetCanExecuteRules(TEntity entity, DetailView view)
        {
            var actionEnabled = _tralusSimpleAction.Enabled;

            if (view != null)
            {
                actionEnabled.SetItemValue("Just Show in DetailView EditMode state", view.ViewEditMode == ViewEditMode.Edit);
                actionEnabled.SetItemValue("Should not be in modified state.", !view.ObjectSpace.IsObjectToSave(entity));
            }

            actionEnabled.SetItemValue("CanExecute must be true", CanExecute(entity));
            
        }


        private void ObjectSpaceOnModifiedChanged(object sender, EventArgs eventArgs)
        {
            if (IsDetailMode())
            {
                SetCanExecuteRules(SelectedObject, GetDetailView());
            }
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            if (IsDetailMode())
            {
                GetDetailView().ObjectSpace.ModifiedChanged -= ObjectSpaceOnModifiedChanged;
            }
        }

        protected bool IsListMode()
        {
            return View is ListView;
        }

        protected bool IsDetailMode()
        {
            return View is DetailView;
        }

        public DetailView GetDetailView()
        {
            return View as DetailView;
        }

        public ListView GetListView()
        {
            return View as ListView;
        }

        protected TEntity SelectedObject
        {
            get
            {
                if (IsDetailMode())
                {
                    return (TEntity)(GetDetailView().CurrentObject);
                }
                throw new Exception(string.Format("SelectedObject is not valid for View: {0}", View));
            }
        }

        protected IEnumerable<TEntity> SelectedObjects
        {
            get
            {
                if (IsListMode())
                {
                    return (GetListView().SelectedObjects.Cast<TEntity>());
                }
                throw new Exception(string.Format("SelectedObjects is not valid for View: {0}", View));
            }
        }

        private void tralusSimpleAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            if (IsMultipleExecutionSupported && IsListMode())
            {
                Execute(SelectedObjects);
            }
            else if (IsDetailMode())
            {
                Execute(SelectedObject);
            }
            else
            {
                // This return is to avoid exection of AfterExecute when no condition hits.
                return;
            }

            AfterExecute();
        }

        public bool CanExecute(TEntity entity)
        {
            return OnCanExecute(entity);
        }

        public bool CanExecute(IEnumerable<TEntity> entities)
        {
            return MultipleExecution.OnCanExecute(entities);
        }

        private IMultipleExecution<TEntity> MultipleExecution
        {
            get
            {
                var multipleExecution = this as IMultipleExecution<TEntity>;
                if (multipleExecution != null)
                {
                    return multipleExecution;
                }
                throw new Exception(string.Format("Multiple Execution is not supported on: '{0}'", this));
            }
        }

        public bool IsMultipleExecutionSupported
        {
            get { return this is IMultipleExecution<TEntity>; }
        }

        protected virtual bool OnCanExecute(TEntity entity)
        {
            return true;
        }


        public void Execute(TEntity entity)
        {
            OnExecute(entity);
            ObjectSpace.SetModified(entity);
            ObjectSpace.CommitChanges();}

        public void Execute(IEnumerable<TEntity> entities)
        {
            MultipleExecution.OnExecute(entities);
        }

        protected virtual void OnExecute(TEntity entity)
        {

        }


        protected virtual void RefreshDetailViewItems(params string[] properties)
        {
            if (IsDetailMode())
            {
                var detailView = GetDetailView();
                foreach (var property in properties)
                {
                    detailView.FindItem(property).Refresh();
                }
            }
        }

        protected bool CanExecuteForAll(IEnumerable<TEntity> entities)
        {
            return entities.All(CanExecute);
        }

        protected bool CanExecuteForAny(IEnumerable<TEntity> entities)
        {
            return entities.All(CanExecute);
        }

        protected void ExecuteOneByOne(IEnumerable<TEntity> entities)
        {
            entities.ForEach(Execute);
        }

    }
}
