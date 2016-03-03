namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOverallRemarkDelayInDelayandTitleInFlightRemark : DbMigration
    {
        public override void Up()
        {
            AddColumn("Stations.FlightDelay", "OverllDelayRemarks", c => c.String());
            AddColumn("Stations.FlightRemark", "Title", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("Stations.FlightRemark", "Title");
            DropColumn("Stations.FlightDelay", "OverllDelayRemarks");
        }
    }
}
