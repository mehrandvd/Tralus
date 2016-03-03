namespace Mahan.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfSevralClassesToFixedType : DbMigration
    {
        public override void Up()
        {
            AddColumn("Infrastructure.CargoType", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.PassengerType", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.SeatClass", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.TicketType", "ProgrammingKey", c => c.String());
            AlterColumn("Infrastructure.CargoType", "Name", c => c.String());
            AlterColumn("Infrastructure.PassengerType", "Name", c => c.String());
            AlterColumn("Infrastructure.SeatClass", "Name", c => c.String());
            AlterColumn("Infrastructure.TicketType", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("Infrastructure.TicketType", "Name", c => c.String(maxLength: 200));
            AlterColumn("Infrastructure.SeatClass", "Name", c => c.String(maxLength: 200));
            AlterColumn("Infrastructure.PassengerType", "Name", c => c.String(maxLength: 200));
            AlterColumn("Infrastructure.CargoType", "Name", c => c.String(maxLength: 200));
            DropColumn("Infrastructure.TicketType", "ProgrammingKey");
            DropColumn("Infrastructure.SeatClass", "ProgrammingKey");
            DropColumn("Infrastructure.PassengerType", "ProgrammingKey");
            DropColumn("Infrastructure.CargoType", "ProgrammingKey");
        }
    }
}
