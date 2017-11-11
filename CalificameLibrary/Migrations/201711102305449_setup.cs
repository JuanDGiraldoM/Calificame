namespace CalificameLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comentarios", "Texto", c => c.String());
            AddColumn("dbo.Comentarios", "Fecha", c => c.DateTime(nullable: false));
            DropColumn("dbo.Comentarios", "Comment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comentarios", "Comment", c => c.String());
            DropColumn("dbo.Comentarios", "Fecha");
            DropColumn("dbo.Comentarios", "Texto");
        }
    }
}
