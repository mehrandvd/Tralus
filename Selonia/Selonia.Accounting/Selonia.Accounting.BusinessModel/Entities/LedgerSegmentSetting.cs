using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selonia.Accounting.BusinessModel;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    /// <summary>
    /// توضیح بیزنسی این موجودیت اینجا نوشته شود
    /// این توضیح باید شرح دهد ماهیت بیزنسی این موجودیت چیست و در چه مواقعی استفاده می‌شود
    /// </summary>
    [Table("Accounting.LedgerSegmentSetting")]
    [DefaultProperty("SegmentGroup")]
    public class LedgerSegmentSetting : EntityBase
    {
        /// <summary>
        /// گروه تفصیلی که در این سطح قابل استفاده است
        /// </summary>
        public virtual SegmentGroup SegmentGroup { get; set; }

        /// <summary>
        /// سطحی که این تفصیلی باید در آن پر شود
        /// </summary>
        public virtual int Level { get; set; }

        public bool IsMandatory { get; set; }

        public virtual string Description { get; set; }

        /// <summary>
        /// معین
        /// </summary>
        public virtual AccLedger Ledger { get; set; }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            // Initialization code comes here.
            // This method will be called only when a new object of this type is created.

            // Initialize Complex types here like:
            // Location = new Location();
        }

        #region Tralus code

        public LedgerSegmentSetting()
        {
        }

        public LedgerSegmentSetting(bool initialize) : base(initialize)
        {
        }

        #endregion

    }
}
