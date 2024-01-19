namespace ECommerceWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_subcribe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Subscribe", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Subscribe", "Description");
            DropColumn("dbo.tb_Subscribe", "Image");
            DropColumn("dbo.tb_Subscribe", "Link");
            DropColumn("dbo.tb_Subscribe", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Subscribe", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Subscribe", "Link", c => c.String());
            AddColumn("dbo.tb_Subscribe", "Image", c => c.String());
            AddColumn("dbo.tb_Subscribe", "Description", c => c.String());
            DropColumn("dbo.tb_Subscribe", "CreatedDate");
        }
    }
}
