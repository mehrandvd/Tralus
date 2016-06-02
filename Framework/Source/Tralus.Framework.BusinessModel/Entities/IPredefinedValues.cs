using System.Data.Entity;

namespace Tralus.Framework.BusinessModel.Entities
{
    public interface IPredefinedValues
    {
        void PopulateDbContext(DbContext dbContext);
        int PredefinedValuesApplyingOrder { get; }
    }
}