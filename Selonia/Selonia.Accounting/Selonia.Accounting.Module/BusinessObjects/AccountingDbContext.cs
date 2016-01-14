using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;

namespace  Selonia.Accounting.Module.BusinessObjects {
	public class AccountingDbContext : DbContext {
		public AccountingDbContext(String connectionString)
			: base(connectionString) {
		}
		public AccountingDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	}
}