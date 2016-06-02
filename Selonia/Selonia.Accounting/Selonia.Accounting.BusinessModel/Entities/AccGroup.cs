using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base.General;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class AccGroup : AccStructure, IPredefinedValues
    {
        public AccGroup()
        {
            Generals = new Collection<AccGeneral>();
        }

        public virtual ICollection<AccGeneral> Generals { get; set; }
        

        public override IHierarchyEntity Parent
        {
            get { return null; }
            set { }
        }

        public override IBindingList Children => new BindingList<AccGeneral>(Generals.ToList());
        public void PopulateDbContext(DbContext dbContext)
        {
            dbContext.Set<EntityNumbering>()
                .AddIfNotExists(
                    new EntityNumbering()
                    {
                        Id = new Guid("EADFC042-DBF1-4BEA-A66D-F165FBB76448"),
                        Title = "AccGroup.Code numbering",
                        PropertyName = "Code",
                        TargetType = typeof(AccGroup),
                        Script = @"Sequence.GetNext(sequenceName: ""AccGroup"").ToString()",
                        WhenToRun = WhenToRun.OnSaving
                    }
                );

            dbContext.Set<EntityNumbering>()
                .AddIfNotExists(
                    new EntityNumbering()
                    {
                        Id = new Guid("DEC4C392-9F9E-4139-9B31-7067B80D5998"),
                        Title = "AccGeneral.Code numbering",
                        PropertyName = "Code",
                        TargetType = typeof(AccGeneral),
                        Script = @"This.Group.Code + Sequence.GetNext(sequenceName: ""AccGeneral"", restartBy1: This.Group).ToString().PadLeft(2,'0')",
                        WhenToRun = WhenToRun.OnSaving
                    }
                );

            dbContext.Set<EntityNumbering>()
                .AddIfNotExists(
                    new EntityNumbering()
                    {
                        Id = new Guid("89EB322F-B379-466B-9B1F-C55308456539"),
                        Title = "AccLedger.Code numbering",
                        PropertyName = "Code",
                        TargetType = typeof(AccLedger),
                        Script = @"This.General.Code + Sequence.GetNext(sequenceName: ""AccLedger"", This.General).PadLeft(3,'0')",
                        WhenToRun = WhenToRun.OnSaving
                    }
                );

            dbContext.SaveChanges();
        }

        public int PredefinedValuesApplyingOrder => 1000;
    }
}