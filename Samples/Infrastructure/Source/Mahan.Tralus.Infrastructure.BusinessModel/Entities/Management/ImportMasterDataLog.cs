using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("ImportMasterDataLog", Schema = "Infrastructure")]
    public class ImportMasterDataLog : EntityBase
    {
        protected override void OnInitialize()
        {
            base.OnInitialize();
            LogDateTime = DateTime.UtcNow;
        }

        public DateTime LogDateTime { get; set; }
        
        public string Creator { get; set; }

        public string LogResult { get; set; }

        public TimeSpan? Duration { get; set; }

        public bool? IsFailed { get; set; }

        public void Log(string message)
        {
            LogResult += string.Format("{0}{1}", message, Environment.NewLine);
        }
    }
}
