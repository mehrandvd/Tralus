using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    [Table("Accounting.SegmentGroup")]
    [DefaultProperty("Name")]
    public class SegmentGroup : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}