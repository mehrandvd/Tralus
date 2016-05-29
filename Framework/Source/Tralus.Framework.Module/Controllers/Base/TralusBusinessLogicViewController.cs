using System;
using System.Threading;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module
{

    /// <summary>
    /// Inherit from this class to create a view controller based on a business logic.
    /// </summary>
    /// <typeparam name="TEntity">This controller will run on this type of entity.</typeparam>
    public abstract class TralusBusinessLogicViewController<TEntity> : TralusEntitySimpleViewController<TEntity> where TEntity : EntityBase
    {
        private TralusEntityBusinessLogic<TEntity> _businessLogic;

        /// <summary>
        /// Override this method to specify what business logic should run.
        /// </summary>
        /// <returns></returns>
        protected virtual TralusEntityBusinessLogic<TEntity> HowToCreateBusinessLogic()
        {
            throw new InvalidOperationException(string.Format("HowToCreateBusinessLogic should be overriden in: {0}", GetType()));
        }

        /// <summary>
        /// Gets the business logic used in the controller.
        /// </summary>
        public TralusEntityBusinessLogic<TEntity> BusinessLogic
        {
            get
            {
                LazyInitializer.EnsureInitialized(ref _businessLogic,
                    () =>
                    {
                        var createdBusinessLogic = HowToCreateBusinessLogic();
                        createdBusinessLogic.ObjectSpace = ObjectSpace;
                        return createdBusinessLogic;
                    });
                return _businessLogic;
            }
        }

        /// <summary>
        /// Override to customize how controller runs business logic.
        /// </summary>
        /// <param name="entity"></param>
        protected override void OnExecute(TEntity entity)
        {
            base.OnExecute(entity);
            BusinessLogic.Execute();
        }


        /// <summary>
        /// Override to customize how the controller checks the availability of the action.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected override bool OnCanExecute(TEntity entity)
        {
            return BusinessLogic.CanExecute();
        }

        protected override bool IsGrantedImpl()
        {
            return BusinessLogic.IsGranted();
        }

        public override string ToString()
        {
            return string.Format("Controller: '{0}', Logic: '{1}'", base.ToString(), BusinessLogic);
        }
    }

    /// <summary>
    /// Inherit from this class to create a view controller based on a business logic.
    /// </summary>
    /// <typeparam name="TEntity">This controller will run on this type of entity.</typeparam>
    /// <typeparam name="TBusinessLogic">This business logic will run on the entity</typeparam>
    public abstract class TralusBusinessLogicViewController<TEntity, TBusinessLogic> : TralusBusinessLogicViewController<TEntity> 
        where TEntity : EntityBase
        where TBusinessLogic : TralusEntityBusinessLogic<TEntity>, new()
    {
        /// <summary>
        /// Override this method to customize how the business logic is created. The default is the paramterless constructor of <para>TBusinessLogic</para>/>
        /// </summary>
        /// <returns></returns>
        protected override TralusEntityBusinessLogic<TEntity> HowToCreateBusinessLogic()
        {
            return new TBusinessLogic() {SelectedObject = SelectedObject};
        }
    }
}
