using System.Data.Entity;

namespace Tralus.Framework.BusinessModel.Entities
{
    public interface IPredefinedData
    {
        void PredefineData(DbContext dbContext);
        int PredefinedDataApplyingOrder { get; }
    }
}