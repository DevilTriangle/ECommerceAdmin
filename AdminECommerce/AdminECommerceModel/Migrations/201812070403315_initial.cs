namespace AdminECommerceModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 100, unicode: false),
                        Address = c.String(),
                        Image = c.String(maxLength: 50, unicode: false),
                        RoleID = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(maxLength: 255, unicode: false),
                        LandLine = c.String(maxLength: 50, unicode: false),
                        CellPhone = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Skype = c.String(maxLength: 255, unicode: false),
                        Facebook = c.String(maxLength: 255, unicode: false),
                        Gmail = c.String(maxLength: 255, unicode: false),
                        Twitter = c.String(maxLength: 255, unicode: false),
                        Instagram = c.String(maxLength: 255, unicode: false),
                        Working = c.String(maxLength: 255, unicode: false),
                        AccountID = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Message = c.String(),
                        AccountID = c.String(maxLength: 50, unicode: false),
                        IsAnswered = c.Boolean(),
                        AnsweredAccountId = c.String(maxLength: 128),
                        Answer = c.String(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        AccountID = c.String(nullable: false, maxLength: 50, unicode: false),
                        DatePurchased = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50, unicode: false),
                        Total = c.Double(nullable: false),
                        Name = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50, unicode: false),
                        Address = c.String(),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        SaleOff = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Double(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Image1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        Image2 = c.String(maxLength: 50, unicode: false),
                        Image3 = c.String(maxLength: 50, unicode: false),
                        Image4 = c.String(maxLength: 50, unicode: false),
                        Manufacturer = c.String(maxLength: 50),
                        Description = c.String(),
                        ShortDescription = c.String(maxLength: 255),
                        OtherInfo = c.String(maxLength: 255),
                        Stock = c.Int(nullable: false),
                        DateArrivals = c.DateTime(nullable: false),
                        SaleOff = c.Double(),
                        AttVal1 = c.String(maxLength: 255),
                        AttVal2 = c.String(maxLength: 255),
                        AttVal3 = c.String(maxLength: 255),
                        AttVal4 = c.String(maxLength: 255),
                        AttVal5 = c.String(maxLength: 255),
                        AttVal6 = c.String(maxLength: 255),
                        AttVal7 = c.String(maxLength: 255),
                        AttVal8 = c.String(maxLength: 255),
                        AttVal9 = c.String(maxLength: 255),
                        AttVal10 = c.String(maxLength: 255),
                        RatingScore = c.Int(),
                        NumOfRates = c.Int(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductID = c.String(maxLength: 50, unicode: false),
                        Image = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        AttName1 = c.String(maxLength: 255),
                        AttName2 = c.String(maxLength: 255),
                        AttName3 = c.String(maxLength: 255),
                        AttName4 = c.String(maxLength: 255),
                        AttName5 = c.String(maxLength: 255),
                        AttName6 = c.String(maxLength: 255),
                        AttName7 = c.String(maxLength: 255),
                        AttName8 = c.String(maxLength: 255),
                        AttName9 = c.String(maxLength: 255),
                        AttName10 = c.String(maxLength: 255),
                        Image = c.String(maxLength: 100),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        Discount = c.Double(nullable: false),
                        Description = c.String(unicode: false),
                        Type = c.Int(nullable: false),
                        ProductID = c.String(maxLength: 50, unicode: false),
                        AccountID = c.String(nullable: false, maxLength: 50, unicode: false),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.String(maxLength: 50, unicode: false),
                        Title = c.String(maxLength: 255),
                        AccountId = c.String(maxLength: 50, unicode: false),
                        Content = c.String(),
                        Rating = c.Int(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 10),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Wishlist",
                c => new
                    {
                        AccountID = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.AccountID, t.ProductID })
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Accounts", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Wishlist", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Wishlist", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Orders", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Promotions", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Banners", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Messages", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Contacts", "AccountID", "dbo.Accounts");
            DropIndex("dbo.Wishlist", new[] { "ProductID" });
            DropIndex("dbo.Wishlist", new[] { "AccountID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Reviews", new[] { "AccountId" });
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            DropIndex("dbo.Promotions", new[] { "ProductID" });
            DropIndex("dbo.Banners", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "AccountID" });
            DropIndex("dbo.Messages", new[] { "AccountID" });
            DropIndex("dbo.Contacts", new[] { "AccountID" });
            DropIndex("dbo.Accounts", new[] { "RoleID" });
            DropTable("dbo.Wishlist");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.Reviews");
            DropTable("dbo.Promotions");
            DropTable("dbo.Categories");
            DropTable("dbo.Banners");
            DropTable("dbo.Products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Messages");
            DropTable("dbo.Contacts");
            DropTable("dbo.Accounts");
        }
    }
}
