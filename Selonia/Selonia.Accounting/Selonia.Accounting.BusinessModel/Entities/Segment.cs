using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    [Table("Accounting.Segment")]
    public class Segment : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual SegmentGroup SegmentGroup { get; set; }
    }
}