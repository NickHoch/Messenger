namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chnagedatetimetosendtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "SendTime", c => c.DateTime());
            DropColumn("dbo.Messages", "DataTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "DataTime", c => c.DateTime());
            DropColumn("dbo.Messages", "SendTime");
        }
    }
}
