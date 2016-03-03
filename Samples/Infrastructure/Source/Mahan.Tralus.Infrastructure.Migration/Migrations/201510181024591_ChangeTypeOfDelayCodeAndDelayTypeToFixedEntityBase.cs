namespace Mahan.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfDelayCodeAndDelayTypeToFixedEntityBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("Infrastructure.DelayCode", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.DelayCode", "Name", c => c.String());
            AddColumn("Infrastructure.DelayType", "ProgrammingKey", c => c.String());
            AlterColumn("Infrastructure.DelayType", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("Infrastructure.DelayType", "Name", c => c.String(maxLength: 200));
            DropColumn("Infrastructure.DelayType", "ProgrammingKey");
            DropColumn("Infrastructure.DelayCode", "Name");
            DropColumn("Infrastructure.DelayCode", "ProgrammingKey");
        }
    }
}
