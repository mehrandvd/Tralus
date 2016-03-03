using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.SystemModule;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module.Security;

namespace Tralus.Framework.Module
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
                SetSecurityRules(SelectedObject, detailView);

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
                _tralusSimpleAction.Executing += (sender, args) => Demand();
            }
        }

        private void SetCanExecuteRules(TEntity entity, DetailView view)
        {
            var actionEnabled = _tralusSimpleAction.Enabled;

            if (view != null)
            {
                actionEnabled.SetItemValue("Just Show in DetailView EditMode state", view.ViewEditMode == ViewEditMode.Edit);

                if (!IsAvailableEvenObjectIsModified)
                {
                    actionEnabled.SetItemValue("Should not be in modified state.", !view.ObjectSpace.IsObjectToSave(entity));
                }
            }

            actionEnabled.SetItemValue("CanExecute must be true", CanExecute(entity));

        }

        private void SetSecurityRules(TEntity entity, DetailView view)
        {

            if (SecuritySystem.Instance is IRequestSecurity)
            {
                _tralusSimpleAction.Active.SetItemValue("Security", IsGranted());
            }

        }

        protected virtual bool IsGrantedImpl()
        {
            var requests = GetPermissionRequests();
            if (requests == null)
                return true;

            return requests.Any(SecuritySystem.IsGranted);
        }

        public void Demand()
        {
            if (!IsGranted())
                throw new SecurityException(string.Format("You don't have access to run: {0}", ToString()));
        }

        public bool IsGranted()
        {
            return IsGrantedImpl();
        }

        protected virtual IEnumerable<IPermissionRequest> GetPermissionRequests()
        {
            return null;
        }

        private void ObjectSpaceOnModifiedChanged(object sender, EventArgs eventArgs)
        {
            if (IsDetailMode())
            {
                SetCanExecuteRules(SelectedObject, GetDetailView());
                SetSecurityRules(SelectedObject, GetDetailView());
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
            if (IsDetailMode())
            {
                return OnCanExecute(entity);
            }
            return false;
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

        /// <summary>
        /// Override this and return true if you want the logic be available when object is modified.
        /// By default logics are not available if object is modified. If you return true, object will be 
        /// available even if object is modified. But object WILL NOT SAVE AUTOMATICALLY after running logic.
        /// The user should Save object after execution of logic.
        /// </summary>
        protected bool IsAvailableEvenObjectIsModified
        {
            get { return false; }
        }


        public void Execute(TEntity entity)
        {
            OnExecute(entity);

            if (!IsAvailableEvenObjectIsModified)
            {
                ObjectSpace.SetModified(entity);
                ObjectSpace.CommitChanges();
            }
        }

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
            entities.ToList().ForEach(Execute);
        }

    }
}
