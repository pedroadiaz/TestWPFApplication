namespace TestWPFApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingSchoolFromTeachers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "SchoolID", "dbo.Schools");
            DropForeignKey("dbo.Students", "SchoolID", "dbo.Schools");
            DropIndex("dbo.Teachers", new[] { "SchoolID" });
            DropIndex("dbo.Students", new[] { "SchoolID" });
            DropColumn("dbo.Teachers", "SchoolID");
            DropColumn("dbo.Students", "SchoolID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "SchoolID", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "SchoolID", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "SchoolID");
            CreateIndex("dbo.Teachers", "SchoolID");
            AddForeignKey("dbo.Students", "SchoolID", "dbo.Schools", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "SchoolID", "dbo.Schools", "ID", cascadeDelete: true);
        }
    }
}
