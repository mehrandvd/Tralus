namespace Mahan.Tralus.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeNameOfAircraftClassFromAircaftsToAircraft : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "Infrastructure.Aircrafts", newName: "Aircraft");
        }
        
        public override void Down()
        {
            RenameTable(name: "Infrastructure.Aircraft", newName: "Aircrafts");
        }
    }
}
