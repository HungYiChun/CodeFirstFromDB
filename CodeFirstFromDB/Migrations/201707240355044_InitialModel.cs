namespace CodeFirstFromDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 256),
                        Username = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                        Name = c.String(maxLength: 256),
                        PhoneNumber = c.String(maxLength: 256),
                        EditTime = c.DateTime(nullable: false),
                        Roles_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Roles_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Roles_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ViewUserDetail",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 256),
                        Username = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                        EditTime = c.DateTime(nullable: false),
                        Name = c.String(maxLength: 256),
                        PhoneNumber = c.String(maxLength: 256),
                        RoleName = c.String(maxLength: 256),
                        StatusName = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => new { t.Id, t.Email, t.Username, t.Password, t.EditTime });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Users", "Roles_Id", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Status_Id" });
            DropIndex("dbo.Users", new[] { "Roles_Id" });
            DropTable("dbo.ViewUserDetail");
            DropTable("dbo.Status");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
