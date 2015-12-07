using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Security
{
    public interface IBusinessLogicPermissionRequest<TEntity> 
        where TEntity : EntityBase
    {
        TralusEntityBusinessLogic<TEntity> BusinessLogic { get; }
        TEntity SelectedObject { get; }
    }
}