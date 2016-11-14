namespace Store.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Good_ID = c.Int(),
                        Cart_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Goods", t => t.Good_ID)
                .ForeignKey("dbo.Carts", t => t.Cart_ID)
                .Index(t => t.Good_ID)
                .Index(t => t.Cart_ID);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CurrentPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "Cart_ID", "dbo.Carts");
            DropForeignKey("dbo.CartItems", "Good_ID", "dbo.Goods");
            DropIndex("dbo.CartItems", new[] { "Cart_ID" });
            DropIndex("dbo.CartItems", new[] { "Good_ID" });
            DropTable("dbo.Carts");
            DropTable("dbo.Goods");
            DropTable("dbo.CartItems");
        }
    }
}
