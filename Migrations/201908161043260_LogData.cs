namespace ChatApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserMessage = c.String(),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogModel");
        }
    }
}
