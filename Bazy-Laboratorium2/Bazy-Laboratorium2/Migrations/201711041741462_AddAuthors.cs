namespace Bazy_Laboratorium2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddAuthors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                {
                    BlogId = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 128),
                });

            AddPrimaryKey("dbo.Authors", new[] { "BlogId", "UserName" });
        }

        public override void Down()
        {
            DropTable("dbo.Authors");
        }
    }
}
