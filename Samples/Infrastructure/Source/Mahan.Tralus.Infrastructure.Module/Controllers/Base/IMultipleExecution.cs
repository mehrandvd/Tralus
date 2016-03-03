using System.Collections.Generic;

namespace Mahan.Tralus.Infrastructure.Module.Controllers
{
    public interface IMultipleExecution<TEntity>
    {
        bool OnCanExecute(IEnumerable<TEntity> entities);
        void OnExecute(IEnumerable<TEntity> entities);
    }
}