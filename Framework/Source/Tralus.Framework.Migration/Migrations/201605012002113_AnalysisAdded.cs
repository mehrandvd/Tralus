namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnalysisAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Analyses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Criteria = c.String(),
                        ObjectTypeName = c.String(),
                        DimensionPropertiesString = c.String(),
                        PivotGridSettingsContent = c.Binary(),
                        ChartSettingsContent = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Analyses");
        }
    }
}
