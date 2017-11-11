namespace CalificameLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setup1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comentarios", "NombreUsuario", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comentarios", "NombreUsuario");
        }
    }
}
