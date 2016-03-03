using System.Collections.Generic;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Infrastructure.Module.BusinessLogics;

namespace Mahan.Tralus.Infrastructure.Module.Controllers
{
    public abstract class TralusBusinessLogicViewController<TEntity> : TralusEntitySimpleViewController<TEntity> where TEntity : EntityBase
    {
        protected virtual TralusBusinessLogic<TEntity> BusinessLogic
        {
            get { return null; }
        }

        protected override void OnExecute(TEntity entity)
        {
            base.OnExecute(entity);
            BusinessLogic.Run(entity);
        }

        protected override bool OnCanExecute(TEntity entity)
        {
            return BusinessLogic.CanExecute(entity);
        }

        public override string ToString()
        {
            return string.Format("Controller: '{0}', Logic: '{1}'", base.ToString(), BusinessLogic) ;
        }
    }
}