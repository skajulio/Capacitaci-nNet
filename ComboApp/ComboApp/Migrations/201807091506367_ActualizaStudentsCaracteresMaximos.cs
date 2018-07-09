namespace ComboApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizaStudentsCaracteresMaximos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Nombre", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Nombre", c => c.String(nullable: false));
        }
    }
}
