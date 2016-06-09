namespace PNFun.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BadLink",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReportedDate = c.DateTime(nullable: false),
                        RecreactionSiteID = c.Int(nullable: false),
                        BadUserID = c.Int(nullable: false),
                        extraa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PhotoLocation = c.String(nullable: false),
                        BackgroundPhotoLocation = c.String(nullable: false),
                        AltDescription = c.String(nullable: false),
                        Hits = c.Int(nullable: false),
                        Ranking = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SubCategory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PhotoLocation = c.String(nullable: false),
                        BackgroundPhotoLocation = c.String(nullable: false),
                        AltDescription = c.String(nullable: false),
                        Hits = c.Int(nullable: false),
                        Ranking = c.Int(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.RecreationSite",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Page = c.String(nullable: false),
                        PhotoLocation = c.String(),
                        AltDescription = c.String(nullable: false),
                        Rating = c.Single(nullable: false),
                        access = c.Int(nullable: false),
                        restrooms = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Directions = c.String(),
                        ImageString = c.String(),
                        MapLink = c.String(),
                        Zipcode = c.String(),
                        SubCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SubCategory", t => t.SubCategory_ID)
                .Index(t => t.SubCategory_ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Comment = c.String(maxLength: 556),
                        UserID = c.Int(nullable: false),
                        RecreationSiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RecreationSite", t => t.RecreationSiteId, cascadeDelete: true)
                .Index(t => t.RecreationSiteId);
            
            CreateTable(
                "dbo.PhotoLink",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        Description = c.String(maxLength: 556),
                        RecreationSiteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RecreationSite", t => t.RecreationSiteId, cascadeDelete: true)
                .Index(t => t.RecreationSiteId);
            
            CreateTable(
                "dbo.LinkCategoryToSubCategory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        LinkedToId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LinkSubCategoryToSite",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubCategoryId = c.Int(nullable: false),
                        LinkedToId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MessageBoard",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 64),
                        UserName = c.String(),
                        UserID = c.Int(nullable: false),
                        OriginalMessage_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Message", t => t.OriginalMessage_ID)
                .Index(t => t.OriginalMessage_ID);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 64),
                        MessageText = c.String(),
                        UserName = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reply",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        replyText = c.String(),
                        UserName = c.String(),
                        UserID = c.Int(nullable: false),
                        Reply_ID = c.Int(),
                        Message_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reply", t => t.Reply_ID)
                .ForeignKey("dbo.Message", t => t.Message_ID)
                .Index(t => t.Reply_ID)
                .Index(t => t.Message_ID);
            
            CreateTable(
                "dbo.NonprofitEvent",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhotoURL = c.String(),
                        Description = c.String(),
                        Organization = c.String(nullable: false),
                        ContactName = c.String(nullable: false),
                        Verified = c.Boolean(nullable: false),
                        Expiration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageBoard", "OriginalMessage_ID", "dbo.Message");
            DropForeignKey("dbo.Reply", "Message_ID", "dbo.Message");
            DropForeignKey("dbo.Reply", "Reply_ID", "dbo.Reply");
            DropForeignKey("dbo.SubCategory", "Category_ID", "dbo.Category");
            DropForeignKey("dbo.RecreationSite", "SubCategory_ID", "dbo.SubCategory");
            DropForeignKey("dbo.PhotoLink", "RecreationSiteId", "dbo.RecreationSite");
            DropForeignKey("dbo.Comments", "RecreationSiteId", "dbo.RecreationSite");
            DropIndex("dbo.MessageBoard", new[] { "OriginalMessage_ID" });
            DropIndex("dbo.Reply", new[] { "Message_ID" });
            DropIndex("dbo.Reply", new[] { "Reply_ID" });
            DropIndex("dbo.SubCategory", new[] { "Category_ID" });
            DropIndex("dbo.RecreationSite", new[] { "SubCategory_ID" });
            DropIndex("dbo.PhotoLink", new[] { "RecreationSiteId" });
            DropIndex("dbo.Comments", new[] { "RecreationSiteId" });
            DropTable("dbo.NonprofitEvent");
            DropTable("dbo.Reply");
            DropTable("dbo.Message");
            DropTable("dbo.MessageBoard");
            DropTable("dbo.LinkSubCategoryToSite");
            DropTable("dbo.LinkCategoryToSubCategory");
            DropTable("dbo.PhotoLink");
            DropTable("dbo.Comments");
            DropTable("dbo.RecreationSite");
            DropTable("dbo.SubCategory");
            DropTable("dbo.Category");
            DropTable("dbo.BadLink");
        }
    }
}
