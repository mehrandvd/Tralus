using System.Collections.Generic;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.Module.BusinessLogics
{
    public abstract class TralusBusinessLogic<TEntity> where TEntity:EntityBase
    {
        protected virtual void OnExecute(TEntity entity)
        {
            
        }

        protected virtual void OnExecute(IEnumerable<TEntity> entities)
        {

        }

        protected virtual bool OnCanExecute(TEntity entity)
        {
            return true;
        }

        protected virtual bool OnCanExecute(IEnumerable<TEntity> entities)
        {
            return true;
        }

        public bool CanExecute(TEntity entity)
        {
            return OnCanExecute(entity);
        }

        public void Run(TEntity entity)
        {
            OnExecute(entity);
        }

        public void Run(IEnumerable<TEntity> entities)
        {
            OnExecute(entities);
        }

        public override string ToString()
        {
            return GetType().ToString();
        }
    }
}