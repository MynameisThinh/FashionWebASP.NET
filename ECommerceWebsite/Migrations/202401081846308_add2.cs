namespace ECommerceWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_WishList", "ProductImage_Id", "dbo.tb_ProductImage");
            DropIndex("dbo.tb_WishList", new[] { "ProductImage_Id" });
            DropColumn("dbo.tb_WishList", "ProductImage_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_WishList", "ProductImage_Id", c => c.Int());
            CreateIndex("dbo.tb_WishList", "ProductImage_Id");
            AddForeignKey("dbo.tb_WishList", "ProductImage_Id", "dbo.tb_ProductImage", "Id");
        }
    }
}
