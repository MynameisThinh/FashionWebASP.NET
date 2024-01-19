namespace ECommerceWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableWishList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_WishList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UserName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_WishList", "ProductId", "dbo.tb_Product");
            DropIndex("dbo.tb_WishList", new[] { "ProductId" });
            DropTable("dbo.tb_WishList");
        }
    }
}
