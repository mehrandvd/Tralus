using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("Tralus.EntitySequenceItem")]
    public class EntitySequenceItem : EntityBase
    {
        public EntitySequenceItem():base()
        {
            
        }

        public EntitySequenceItem(bool initialize):base(initialize)
        {
            
        }

        public virtual EntitySequence EntitySequence { get; set; }
        public virtual Guid EntitySequenceId { get; set; }
        public virtual DateTime CreationDateTime { get; set; }
        public virtual  long SeqValue { get; set; }

        public virtual string UsedFor { get; set; }

        public virtual string Param1 { get; set; }
        public virtual string Param2 { get; set; }
        public virtual string Param3 { get; set; }
        public virtual string Param4 { get; set; }
        public virtual string Param5 { get; set; }
    }
}