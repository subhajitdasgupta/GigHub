namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gigs", "GenreId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gigs", "GenreId", c => c.Byte(nullable: false));
        }
    }
}
