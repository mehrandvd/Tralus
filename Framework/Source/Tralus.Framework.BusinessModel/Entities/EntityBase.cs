using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;

namespace Tralus.Framework.BusinessModel.Entities
{
    public class EntityBase : IXafEntityObject, IObjectSpaceLink
    {
        /// <summary>
        /// The key of this entity.
        /// </summary>
        [Browsable(false)]
        public Guid Id { get; set; }

        public EntityBase()
        {
            
        }

        public EntityBase(bool initialize) : this()
        {
            ((IXafEntityObject) this).OnCreated();
        }

        /// <summary>
        /// Override to add some initializations for new objects.
        /// </summary>
        protected virtual void OnInitialize()
        {
        }

        /// <summary>
        /// Initializes the tntity
        /// </summary>
        private void ApplyInitializationRules()
        {
            Id = Guid.NewGuid();
            State = ObjectState.New;
            OnInitialize();
        }

        protected virtual void OnRetrieve()
        {
        }

        /// <summary>
        /// Initializes the tntity
        /// </summary>
        private void ApplyRetrieveRules()
        {
            State = ObjectState.Unchanged;
            OnRetrieve();
        }

        protected virtual void OnSave()
        {
        }

        /// <summary>
        /// Initializes the entity
        /// </summary>
        private void ApplySaveRules()
        {
            State = ObjectState.Unchanged;
            OnSave();
        }

        void IXafEntityObject.OnCreated()
        {
            ApplyInitializationRules();
        }

        void IXafEntityObject.OnSaving()
        {
            ApplySaveRules();
        }

        void IXafEntityObject.OnLoaded()
        {
            ApplyRetrieveRules();
        }

        IObjectSpace IObjectSpaceLink.ObjectSpace { get; set; }

        // ToDo: Check if it is not required and should be removed.
        //public static IList<string> AvailablePermissions { get { return new string[] { }; } }

        public static XafApplication Application { get; private set; }

        public static void SetApplication(XafApplication application)
        {
            Application = application;
        }

        public static IObjectSpace CreateObjectSpace(Type type)
        {
            return Application?.CreateObjectSpace(type);
        }

        [NotMapped]
        [Browsable(false)]
        private ObjectState State { get; set; }

        public bool IsNew()
        {
            return State == ObjectState.New;
        }
    
    }
}
