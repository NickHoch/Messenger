namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatetimenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "DataTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "DataTime", c => c.DateTime(nullable: false));
        }
    }
}
