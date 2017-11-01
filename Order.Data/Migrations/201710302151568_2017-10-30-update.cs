namespace Order.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20171030update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetail", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetail", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetail", "Total");
            DropColumn("dbo.OrderDetail", "Price");
        }
    }
}
