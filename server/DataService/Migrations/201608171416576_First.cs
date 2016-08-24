namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lunch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LunchTime = c.DateTime(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurant", t => t.RestaurantId, cascadeDelete: false)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Restaurant",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rating",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StarRating = c.Int(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Restaurant", t => t.RestaurantId, cascadeDelete: false)
                .Index(t => t.RestaurantId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.LunchEmployee",
                c => new
                    {
                        Lunch_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Lunch_Id, t.Employee_Id })
                .ForeignKey("dbo.Lunch", t => t.Lunch_Id, cascadeDelete: false)
                .ForeignKey("dbo.Employee", t => t.Employee_Id, cascadeDelete: false)
                .Index(t => t.Lunch_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lunch", "RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Rating", "RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Rating", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.LunchEmployee", "Employee_Id", "dbo.Employee");
            DropForeignKey("dbo.LunchEmployee", "Lunch_Id", "dbo.Lunch");
            DropIndex("dbo.LunchEmployee", new[] { "Employee_Id" });
            DropIndex("dbo.LunchEmployee", new[] { "Lunch_Id" });
            DropIndex("dbo.Rating", new[] { "EmployeeId" });
            DropIndex("dbo.Rating", new[] { "RestaurantId" });
            DropIndex("dbo.Lunch", new[] { "RestaurantId" });
            DropTable("dbo.LunchEmployee");
            DropTable("dbo.Rating");
            DropTable("dbo.Restaurant");
            DropTable("dbo.Lunch");
            DropTable("dbo.Employee");
        }
    }
}
