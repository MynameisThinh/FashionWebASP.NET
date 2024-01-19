namespace ECommerceWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_WishList", "ProductImage_Id", c => c.Int());
            CreateIndex("dbo.tb_WishList", "ProductImage_Id");
            AddForeignKey("dbo.tb_WishList", "ProductImage_Id", "dbo.tb_ProductImage", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_WishList", "ProductImage_Id", "dbo.tb_ProductImage");
            DropIndex("dbo.tb_WishList", new[] { "ProductImage_Id" });
            DropColumn("dbo.tb_WishList", "ProductImage_Id");
        }
    }
}
