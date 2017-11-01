namespace Order.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Status = c.Byte(nullable: false),
                        Comment = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "OrderId", "dbo.Order");
            DropIndex("dbo.OrderDetail", new[] { "OrderId" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
        }
    }
}
