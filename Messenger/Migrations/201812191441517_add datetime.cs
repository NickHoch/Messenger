namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "DataTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "DataTime");
        }
    }
}
