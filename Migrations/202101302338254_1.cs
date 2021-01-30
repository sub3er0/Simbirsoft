namespace Simbirsoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Words", "SplittedWord", c => c.String(nullable: false, maxLength: 350));
            AddPrimaryKey("dbo.Words", "SplittedWord");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Words", "SplittedWord", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Words", "SplittedWord");
        }
    }
}
