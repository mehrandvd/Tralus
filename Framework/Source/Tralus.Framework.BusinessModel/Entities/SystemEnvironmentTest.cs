using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("Tralus.SystemEnvironmentTest")]
    public class SystemEnvironmentTest : EntityBase
    {
        protected override void OnInitialize()
        {
            base.OnInitialize();

            MachineName = Environment.MachineName;

            DateTime now = DateTime.Now;
            TestTime = now;

            Name = string.Format("{0}: [{1}]", MachineName, now.ToString("s"));
        }

        public DateTime TestTime { get; set; }

        public string Name { get; set; }

        public string MachineName { get; set; }
        public string Database { get; set; }
        public string TestLog { get; set; }

        public long? AverageTime1B { get; set; }
        public long? AverageTime1K { get; set; }
        public long? AverageTime10K { get; set; }
        public long? AverageTime100K { get; set; }
        public long? AverageTime1000K { get; set; }
        public long? LoadAllTime { get; set; }
        public long? LoadAllCount { get; set; }
        public long? PackSize { get; set; }


    }
}
