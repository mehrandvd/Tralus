using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text.RegularExpressions;


using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
namespace Tralus.Framework.Data.Database.Conventions
{
    //class SchemaFromNamespaceConvention : IConceptualModelConvention<EntitySet> 
    //{

    //    public void Apply(EntitySet item, DbModel model)
    //    {
    //        var metadataProperty = item.ElementType.MetadataProperties["http://schemas.microsoft.com/ado/2013/11/edm/customannotation:ClrType"];

    //        if (metadataProperty != null)
    //        {
    //            var ns = ((System.Type) (metadataProperty.Value)).Namespace ?? "";

    //            var match = Regex.Match(ns, @"Tralus.(?<SchemaName>\w*).*");
    //            if (match.Success)
    //            {
    //                var schemaName = match.Groups["SchemaName"].Value;
    //                item.Schema = schemaName;
    //            }
    //        }
    //    }
    //}

    //class SchemaFromNamespaceConvention2 : Convention
    //{
    //    public SchemaFromNamespaceConvention2()
    //    {
            
    //    }
    //}



    //public class SchemaFromNamespaceConvention3 : IStoreModelConvention<EntityType>
    //{
    //    public void Apply(EntityType item, DbModel model)
    //    {
    //        var entitySet = model.StoreModel.GetEntitySet(item);

    //        //entitySet.Table
    //    }
    //}
}