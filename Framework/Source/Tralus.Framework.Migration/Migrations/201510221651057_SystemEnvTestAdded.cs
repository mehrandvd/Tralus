namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SystemEnvTestAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "System.DummyObject",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DummyData = c.Binary(),
                        TestPack = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.SystemEnvironmentTest",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TestTime = c.DateTime(nullable: false),
                        Name = c.String(),
                        MachineName = c.String(),
                        Database = c.String(),
                        TestLog = c.String(),
                        AverageTime1B = c.Long(),
                        AverageTime1K = c.Long(),
                        AverageTime10K = c.Long(),
                        AverageTime100K = c.Long(),
                        AverageTime1000K = c.Long(),
                        LoadAllTime = c.Long(),
                        LoadAllCount = c.Long(),
                        PackSize = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("System.SystemEnvironmentTest");
            DropTable("System.DummyObject");
        }
    }
}
