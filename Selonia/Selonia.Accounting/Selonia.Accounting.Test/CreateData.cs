using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NUnit.Framework;
using Selonia.Accounting.BusinessModel;
using Selonia.Accounting.Data.Database;
using Selonia.Accounting.Migration.Migrations;

namespace Selonia.Accounting.Test
{
    [TestFixture]
    public class CreateData
    {
        [Test]
        public void Init()
        {

            Database.SetInitializer<AccountingDbContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccountingDbContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<AccountingDbContext>());

            db = new AccountingDbContext();

            db.Database.ExecuteSqlCommand(
                @"
                    DELETE FROM [Accounting].FiscalYear
                    DELETE FROM [Accounting].LedgerSegmentSetting
                    DELETE FROM [Accounting].VoucherItemSegment
                    DELETE FROM [Accounting].[VoucherItem]
                    DELETE FROM [Accounting].[Voucher]
                    DELETE FROM [Accounting].AccLedger
                    DELETE FROM [Accounting].AccGeneral
                    DELETE FROM [Accounting].AccGroup
                    DELETE FROM [Accounting].VoucherType
                    DELETE FROM [Accounting].Segment
                    DELETE FROM [Accounting].SegmentGroup
               ");

            var fiscalYears = new List<FiscalYear>();
            var voucherTypes = new List<VoucherType>();
            var accGroups = new List<AccGroup>();
            var accGenerals = new List<AccGeneral>();
            var accLedgers = new List<AccLedger>();
            var vouchers = new List<Voucher>();
            var segmentGroups = new List<SegmentGroup>();
            var segments = new List<Segment>();

            fiscalYears.AddRange(
                new List<FiscalYear>
                {
                    new FiscalYear()
                    {
                        Id = Guid.NewGuid(),
                        Name = "1394",
                        StartDate = new DateTime(2015,3,20),
                        EndDate= new DateTime(2016,3,19),
                    },
                    new FiscalYear()
                    {
                        Id = Guid.NewGuid(),
                        Name = "1395",
                        StartDate = new DateTime(2016,3,20),
                        EndDate= new DateTime(2017,3,19),
                    }
                });

            segmentGroups.AddRange(new []
            {
                new SegmentGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "10",
                    Name = "اشخاص حقیقی و حقوقی"
                },
                new SegmentGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "11",
                    Name = "پروژه‌ها"
                },
                new SegmentGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "12",
                    Name = "حساب‌ها"
                },
            });
            InsertToDb(segmentGroups);

            for (var i = 1; i <= 800; i++)
            {
                var segmentGroup = Pick(segmentGroups);
                segments.Add(new Segment()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    SegmentGroup = segmentGroup,
                    Name = $"{segmentGroup.Name} {i}"
                });
            }
            InsertToDb(segments);

            for (var i = 1; i <= 15; i++)
            {
                voucherTypes.Add(new VoucherType()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"نوع سند {i}"
                });
            }
            InsertToDb(voucherTypes);

            for (var i = 1; i <= 10; i++)
            {
                accGroups.Add(new AccGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"گروه حساب {i}"
                });
            }
            InsertToDb(accGroups);


            for (var i = 1; i <= 30; i++)
            {
                accGenerals.Add(new AccGeneral()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"حساب کل {i}",
                    Group = Pick(accGroups)
                });
            }
            InsertToDb(accGenerals);

            for (var i = 1; i <= 200; i++)
            {
                var leftPick = Pick(1, 2);
                var settings = new List<LedgerSegmentSetting>
                {
                    new LedgerSegmentSetting()
                    {
                        Id = Guid.NewGuid(),
                        SegmentGroup = Pick(segmentGroups[0]),
                        Level = leftPick,
                        IsMandatory = false,
                    },
                    new LedgerSegmentSetting()
                    {
                        Id = Guid.NewGuid(),
                        SegmentGroup = Pick(segmentGroups[1]),
                        Level = 3 - leftPick,
                        IsMandatory = false,
                    }
                };

                accLedgers.Add(new AccLedger()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"معین {i}",
                    General = Pick(accGenerals),
                    SegmentSettings = settings
                });
            }
            InsertToDb(accLedgers);

            for (var i = 1; i <= 400; i++)
            {
                var voucherDate = RandomDay();
                var fiscalYear = fiscalYears.First(f => f.StartDate <= voucherDate && voucherDate <= f.EndDate);
                var voucher = new Voucher()
                {
                    Id = Guid.NewGuid(),
                    FixNo = i.ToString(),
                    TempNo = i.ToString(),
                    Description = $"سند حسابداری {i}",
                    VoucherState =
                        Pick(VoucherState.Values.Accepted, VoucherState.Values.Draft, VoucherState.Values.Fixed, VoucherState.Values.Registered),
                    VoucherDate = voucherDate,
                    VoucherType = Pick(voucherTypes),
                    FiscalYear = fiscalYear
                };
                vouchers.Add(voucher);

                voucher.VoucherItems = new List<VoucherItem>();

                var row = 1;

                for (var j = 1; j <= 8; j++)
                {
                    var amount = _random.Next(1000, 1000000);

                    var left = new VoucherItem()
                    {
                        Id = Guid.NewGuid(),
                        Voucher = voucher,
                        Description = $"سند {i}, آرتیکل {j} - شرح بستانکار",
                        Credit = amount,
                        Debit = 0,
                        Ledger = Pick(accLedgers),
                    };
                    left.SetRowNo(row++);

                    PickSegments(left, segments);

                    var right = new VoucherItem()
                    {
                        Id = Guid.NewGuid(),
                        Voucher = voucher,
                        Description = $"سند {i}, آرتیکل {j} - شرح بدهکار",
                        Credit = 0,
                        Debit = amount,
                        Ledger = Pick(accLedgers)
                    };
                    right.SetRowNo(row++);
                    PickSegments(right, segments);

                    voucher.VoucherItems.Add(left);
                    voucher.VoucherItems.Add(right);
                }
                //InsertToDb(new List<Voucher> {voucher});
            }
            InsertToDb(vouchers);


            db.Dispose();
        }

        private void PickSegments(VoucherItem voucherItem, List<Segment> segments)
        {
            var segmentGrouop1 = voucherItem.Ledger.GetSegmentSetting(1).SegmentGroup;
            voucherItem.Segment1 = Pick(segments.Where(s => s.SegmentGroup == segmentGrouop1).ToArray());

            var segmentGrouop2 = voucherItem.Ledger.GetSegmentSetting(2).SegmentGroup;
            voucherItem.Segment2 = Pick(segments.Where(s => s.SegmentGroup == segmentGrouop2).ToArray());
        }

        AccountingDbContext db;
        public void InsertToDb<T>(List<T> data) where T : class
        {
            db.Set<T>().AddRange(data);
            db.SaveChanges();
        }

        readonly Random _random = new Random();

        public T Pick<T>(params T[] data)
        {
            var count = data.Length;

            var randomIndex = _random.Next(0, count - 1);

            return data[randomIndex];
        }

        public T Pick<T>(List<T> data)
        {
            return Pick(data.ToArray());
        }

        DateTime RandomDay()
        {
            DateTime start = new DateTime(2016, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));
        }

    }
}
