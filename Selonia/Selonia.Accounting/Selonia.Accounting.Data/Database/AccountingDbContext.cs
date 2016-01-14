using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.Data;

namespace Selonia.Accounting.Data.Database
{
    public class AccountingDbContext : FrameworkDbContext
    {
        public AccountingDbContext() : base()
        {
            
        }

        public AccountingDbContext(string connectionString) : base(connectionString)
        {

        }

        public AccountingDbContext(DbConnection connection) : base(connection)
        {
        }
    }
}
