using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    [Table("Accounting.AccLedger")]
    public class AccLedger : AccStructure
    {
        public virtual AccGeneral General { get; set; }

        public override IHierarchyEntity Parent
        {
            get { return General; }
            set { General = (AccGeneral) value; }
        }

        public override IBindingList Children => new BindingList<AccLedger>();

        /// <summary>
        /// توضیح بیزنسی این پروپرتی
        /// اینکه دلیل وجود این پروپرتی چیست و چه مواقعی از آن استفاده می‌شود
        /// </summary>
        public virtual ICollection<LedgerSegmentSetting> SegmentSettings { get; set; }

        public LedgerSegmentSetting GetSegmentSetting(int level)
        {
            return SegmentSettings.FirstOrDefault(s => s.Level == level);
        }

        private LedgerSegmentSetting GetSegmentSettingName([CallerMemberName] string callerName = null)
        {
            if (callerName == null)
                return null;

            var callerIndex = callerName.Replace("SegmentSettingName", "");
            int index;
            if (int.TryParse(callerIndex, out index))
            {
                return GetSegmentSetting(index);
            }

            return null;
        }

        public virtual string SegmentSettingName1 => GetSegmentSettingName()?.SegmentGroup?.Name;
        public virtual string SegmentSettingName2 => GetSegmentSettingName()?.SegmentGroup?.Name;
        public virtual string SegmentSettingName3 => GetSegmentSettingName()?.SegmentGroup?.Name;
        public virtual string SegmentSettingName4 => GetSegmentSettingName()?.SegmentGroup?.Name;
    }
}