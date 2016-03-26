namespace OnlinePayment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elec1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Electronics", "CostPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Electronics", "CostPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
