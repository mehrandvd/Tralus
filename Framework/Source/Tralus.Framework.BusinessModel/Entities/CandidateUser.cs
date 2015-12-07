using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.Security;
using DevExpress.Persistent.Validation;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("CandidateUser", Schema = "System")]
    [DefaultProperty("Username")]
    public class CandidateUser : EntityBase
    {
        public String Username { get; set; }

        public string Description { get; set; }
    }
}
