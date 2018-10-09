namespace OnlineShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Post", newName: "Posts");
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Posts", "Content", c => c.String());
            AlterColumn("dbo.Posts", "Image", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "ViewCount", c => c.Int());
            DropColumn("dbo.Posts", "Conten");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Conten", c => c.String());
            AlterColumn("dbo.Posts", "ViewCount", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "Image", c => c.String(maxLength: 500));
            DropColumn("dbo.Posts", "Content");
            DropTable("dbo.Errors");
            RenameTable(name: "dbo.Posts", newName: "Post");
        }
    }
}
