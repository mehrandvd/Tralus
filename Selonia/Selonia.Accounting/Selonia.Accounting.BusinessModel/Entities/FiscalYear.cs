using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    /// <summary>
    /// سال مالی
    /// </summary>
    [Table("Accounting.FiscalYear")]
    [DefaultProperty("Name")]
    public class FiscalYear : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }

        public virtual bool IsDefault { get; set; }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            // Initialization code comes here.
            // This method will be called only when a new object of this type is created.

            // Initialize Complex types here like:
            // Location = new Location();
        }

        #region Tralus code

        public FiscalYear()
        {
        }

        public FiscalYear(bool initialize) : base(initialize)
        {
        }

        #endregion

    }
}
