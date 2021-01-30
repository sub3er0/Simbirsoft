namespace Simbirsoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Words");
            AlterColumn("dbo.Words", "SplittedWord", c => c.String(nullable: false, maxLength: 500));
            AddPrimaryKey("dbo.Words", "SplittedWord");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Words");
            AlterColumn("dbo.Words", "SplittedWord", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Words", "SplittedWord");
        }
    }
}
