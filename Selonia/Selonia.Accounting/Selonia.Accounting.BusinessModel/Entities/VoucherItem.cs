using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    [Table("Accounting.VoucherItem")]
    public class VoucherItem : EntityBase, IOrderedEntity
    {
        private long _debit;
        private long _credit;

        protected override void OnInitialize()
        {
            base.OnInitialize();
            VoucherItemSegments = new List<VoucherItemSegment>();
        }

        public virtual int RowNo { get; private set; }

        public virtual long Debit
        {
            get { return _debit; }
            set
            {
                _debit = value;

                if (Voucher != null)
                    Voucher.DebitSum = null;
            }
        }

        public virtual long Credit
        {
            get { return _credit; }
            set
            {
                _credit = value;

                if (Voucher != null)
                    Voucher.CreditSum = null;
            }
        }

        public virtual AccLedger Ledger { get; set; }

        public virtual string Description { get; set; }

        [DataSourceCriteriaProperty("SegmentCriteria1")]
        [NotMapped]
        public virtual Segment Segment1
        {
            get { return GetSegment(); }
            set { SetSegment(value); }
        }

        [DataSourceCriteriaProperty("SegmentCriteria2")]
        [NotMapped]
        public virtual Segment Segment2
        {
            get { return GetSegment(); }
            set { SetSegment(value); }
        }

        [DataSourceCriteriaProperty("SegmentCriteria3")]
        [NotMapped]
        public virtual Segment Segment3
        {
            get { return GetSegment(); }
            set { SetSegment(value); }
        }

        [DataSourceCriteriaProperty("SegmentCriteria4")]
        [NotMapped]
        public virtual Segment Segment4
        {
            get { return GetSegment(); }
            set { SetSegment(value); }
        }

        [NotMapped]
        public virtual CriteriaOperator SegmentCriteria1 => GetCriteriaOperator();
        public virtual CriteriaOperator SegmentCriteria2 => GetCriteriaOperator();
        public virtual CriteriaOperator SegmentCriteria3 => GetCriteriaOperator();
        public virtual CriteriaOperator SegmentCriteria4 => GetCriteriaOperator();
        //{
        //    get
        //    {
        //        var ledgerSegmentSetting = Ledger.GetSegmentSetting(1);
        //        if (ledgerSegmentSetting != null)
        //        {
        //            return CriteriaOperator.Parse($"[SegmentGroup.Id] = '{ledgerSegmentSetting.SegmentGroup.Id}'");
        //        }
        //        else
        //        {
        //            return CriteriaOperator.Parse($"[SegmentGroup.Name] = ''");
        //        }
        //    }
        //}

        private CriteriaOperator GetCriteriaOperator([CallerMemberName] string callerName = null)
        {
            if (callerName == null)
                return null;

            var callerIndex = callerName.Replace("SegmentCriteria", "");
            int index;

            if (int.TryParse(callerIndex, out index))
            {
                var ledgerSegmentSetting = Ledger.GetSegmentSetting(index);
                if (ledgerSegmentSetting != null)
                {
                    return CriteriaOperator.Parse($"[SegmentGroup.Id] = '{ledgerSegmentSetting.SegmentGroup.Id}'");
                }
                else
                {
                    return CriteriaOperator.Parse($"[SegmentGroup.Name] = ''");
                }
            }

            return null;
        }

        public virtual Voucher Voucher { get; set; }

        public virtual ICollection<VoucherItemSegment> VoucherItemSegments { get; set; }

        private Segment GetSegment([CallerMemberName] string callerName = null)
        {
            if (callerName == null)
                return null;

            var callerIndex = callerName.Replace("Segment", "");
            int index;
            if (int.TryParse(callerIndex, out index))
            {
                var voucherItemSegment = VoucherItemSegments.FirstOrDefault(vis => vis.Level == index);
                return voucherItemSegment?.Segment;
            }

            return null;
        }

        private void SetSegment(Segment newValue, [CallerMemberName] string callerName = null)
        {
            if (callerName == null)
                return;

            var callerIndex = callerName.Replace("Segment", "");
            int index;
            if (int.TryParse(callerIndex, out index))
            {
                if (VoucherItemSegments == null)
                {
                    VoucherItemSegments = new List<VoucherItemSegment>();
                }
                var voucherItemSegment = VoucherItemSegments.FirstOrDefault(vis => vis.Level == index);

                if (voucherItemSegment != null)
                {
                    voucherItemSegment.Segment = newValue;
                }
                else
                {
                    VoucherItemSegments.Add(new VoucherItemSegment()
                    {
                        Id = Guid.NewGuid(),
                        Level = index,
                        Segment = newValue
                    });
                }
            }
        }

        [Obsolete("A controller in framework does this job.")]
        public void SetRowNo(int? rowNo = null)
        {
            if (rowNo.HasValue)
            {
                RowNo = rowNo.Value;
                return;
            }

            if (IsNew() && RowNo == 0)
            {
                RowNo = (Voucher?.VoucherItems.Any() ?? false)
                ? (int)Voucher?.VoucherItems.Max(o => o.RowNo) + 1 : 1;
            }
        }

        public void SetRowNo(int rowNo)
        {
            RowNo = rowNo;
        }

        public int RowNoProperty => RowNo;
        public IEnumerable RefList => Voucher?.VoucherItems;
    }
}