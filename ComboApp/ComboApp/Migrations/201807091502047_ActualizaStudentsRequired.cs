namespace ComboApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizaStudentsRequired : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Edad", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Nombre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Nombre", c => c.String());
            DropColumn("dbo.Students", "Edad");
        }
    }
}
