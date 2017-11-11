namespace CalificameLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setup_1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comentarios", "Fecha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comentarios", "Fecha", c => c.DateTime(nullable: false));
        }
    }
}
