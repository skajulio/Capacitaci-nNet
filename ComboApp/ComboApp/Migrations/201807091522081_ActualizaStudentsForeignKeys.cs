namespace ComboApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizaStudentsForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "CursoId");
            AddForeignKey("dbo.Students", "CursoId", "dbo.Cursoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.Students", new[] { "CursoId" });
            DropColumn("dbo.Students", "CursoId");
            DropTable("dbo.Cursoes");
        }
    }
}
