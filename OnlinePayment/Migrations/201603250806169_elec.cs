namespace OnlinePayment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elec : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Electronics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        DeviceName = c.String(),
                        PurchaseDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Electronics");
        }
    }
}
