using System.Collections.Generic;

namespace Tralus.Framework.Module
{
    public interface IMultipleExecution<in TEntity>
    {
        bool OnCanExecute(IEnumerable<TEntity> entities);
        void OnExecute(IEnumerable<TEntity> entities);
    }
}
