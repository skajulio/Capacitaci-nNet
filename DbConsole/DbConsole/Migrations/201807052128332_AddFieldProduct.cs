namespace DbConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Contenido", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Contenido");
        }
    }
}
