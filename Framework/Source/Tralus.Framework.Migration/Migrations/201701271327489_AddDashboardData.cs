namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDashboardData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DashboardDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Title = c.String(),
                        SynchronizeTitle = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DashboardDatas");
        }
    }
}
