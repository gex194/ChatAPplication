namespace ChatApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoUsers : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.User");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
