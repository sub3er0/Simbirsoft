namespace Simbirsoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        SplittedWord = c.String(nullable: false, maxLength: 128),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SplittedWord);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Words");
        }
    }
}
