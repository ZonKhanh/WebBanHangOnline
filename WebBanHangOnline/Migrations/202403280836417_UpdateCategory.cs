namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_News", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_News", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_News", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Posts", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String());
            DropColumn("dbo.tb_Contact", "SeoTitle");
            DropColumn("dbo.tb_Contact", "SeoDescription");
            DropColumn("dbo.tb_Contact", "SeoKeywords");
            DropColumn("dbo.tb_Order", "SeoTitle");
            DropColumn("dbo.tb_Order", "SeoDescription");
            DropColumn("dbo.tb_Order", "SeoKeywords");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Order", "SeoKeywords", c => c.String(maxLength: 150));
            AddColumn("dbo.tb_Order", "SeoDescription", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Order", "SeoTitle", c => c.String(maxLength: 150));
            AddColumn("dbo.tb_Contact", "SeoKeywords", c => c.String(maxLength: 150));
            AddColumn("dbo.tb_Contact", "SeoDescription", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Contact", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Posts", "SeoKeywords", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Posts", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Posts", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_News", "SeoKeywords", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_News", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_News", "SeoTitle", c => c.String(maxLength: 150));
        }
    }
}
