namespace TestWPFApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeNewMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TimeOfDay = c.String(),
                        ClassLength = c.Int(nullable: false),
                        TeacherID = c.Int(nullable: false),
                        SchoolID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Schools", t => t.SchoolID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.SchoolID);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        Address = c.String(),
                        CityName = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Teachers",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Address = c.String(),
                    CityName = c.String(),
                    State = c.String(),
                    ZipCode = c.String(),
                    PhoneNumber = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        CityName = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentClasses", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "SchoolID", "dbo.Schools");
            DropForeignKey("dbo.StudentClasses", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Classes", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "SchoolID", "dbo.Schools");
            DropForeignKey("dbo.Classes", "SchoolID", "dbo.Schools");
            DropIndex("dbo.Students", new[] { "SchoolID" });
            DropIndex("dbo.StudentClasses", new[] { "StudentID" });
            DropIndex("dbo.StudentClasses", new[] { "ClassID" });
            DropIndex("dbo.Teachers", new[] { "SchoolID" });
            DropIndex("dbo.Classes", new[] { "SchoolID" });
            DropIndex("dbo.Classes", new[] { "TeacherID" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentClasses");
            DropTable("dbo.Teachers");
            DropTable("dbo.Schools");
            DropTable("dbo.Classes");
        }
    }
}
