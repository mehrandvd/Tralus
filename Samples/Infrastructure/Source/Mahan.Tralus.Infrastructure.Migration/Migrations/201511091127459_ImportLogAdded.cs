namespace Mahan.Tralus.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImportLogAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Infrastructure.ImportMasterDataLog",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LogDateTime = c.DateTime(nullable: false),
                        Creator = c.String(),
                        LogResult = c.String(),
                        Duration = c.Time(precision: 7),
                        IsFailed = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Infrastructure.ImportMasterDataLog");
        }
    }
}
