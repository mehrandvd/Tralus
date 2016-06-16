using System;
using System.Collections.Generic;
using System.Data.Entity;
using NUnit.Framework;
using Selonia.Accounting.BusinessModel.Entities;
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

            var voucherTypes = new List<VoucherType>();
            var accGroups = new List<AccGroup>();
            var accGenerals = new List<AccGeneral>();
            var accLedgers = new List<AccLedger>();
            var vouchers = new List<Voucher>();



            for (var i = 1; i <= 15; i++)
            {
                voucherTypes.Add(new VoucherType()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"Voucher Type {i}"
                });
            }
            InsertToDb(voucherTypes);

            for (var i = 1; i <= 10; i++)
            {
                accGroups.Add(new AccGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"Acc Group {i}"
                });
            }
            InsertToDb(accGroups);


            for (var i = 1; i <= 30; i++)
            {
                accGenerals.Add(new AccGeneral()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"Acc General {i}",
                    Group = Pick(accGroups)
                });
            }
            InsertToDb(accGenerals);

            for (var i = 1; i <= 200; i++)
            {
                accLedgers.Add(new AccLedger()
                {
                    Id = Guid.NewGuid(),
                    Code = i.ToString(),
                    Name = $"Acc Ledger {i}",
                    General = Pick(accGenerals)
                });
            }
            InsertToDb(accLedgers);

            for (var i = 1; i <= 400; i++)
            {
                var voucher = new Voucher()
                {
                    Id = Guid.NewGuid(),
                    FixNo = i.ToString(),
                    TempNo = i.ToString(),
                    Description = $"Voucher {i}",
                    VoucherState = null,
                    VoucherDate = RandomDay(),
                    VoucherType = Pick(voucherTypes)
                };
                vouchers.Add(voucher);

                voucher.VoucherItems = new List<VoucherItem>();

                for (var j = 1; j <= 8; j++)
                {
                    var amount = _random.Next(1000, 1000000);

                    var left = new VoucherItem()
                    {
                        Id = Guid.NewGuid(),
                        Voucher = voucher,
                        Description = $"Voucher {i}, Voucher Item {j} - Left",
                        Credit = amount,
                        Debit = 0,
                        Ledger = Pick(accLedgers)
                    };

                    var right = new VoucherItem()
                    {
                        Id = Guid.NewGuid(),
                        Voucher = voucher,
                        Description = $"Voucher {i}, Voucher Item {j} - Right",
                        Credit = 0,
                        Debit = amount,
                        Ledger = Pick(accLedgers)
                    };

                    voucher.VoucherItems.Add(left);
                    voucher.VoucherItems.Add(right);
                }
                //InsertToDb(new List<Voucher> {voucher});
            }
            InsertToDb(vouchers);


            db.Dispose();
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
