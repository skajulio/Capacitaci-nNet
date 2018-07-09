namespace WebHelpers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearTablaCurso : DbMigration
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
            
            AddColumn("dbo.Students", "Curso_Id", c => c.Int());
            CreateIndex("dbo.Students", "Curso_Id");
            AddForeignKey("dbo.Students", "Curso_Id", "dbo.Cursoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Curso_Id", "dbo.Cursoes");
            DropIndex("dbo.Students", new[] { "Curso_Id" });
            DropColumn("dbo.Students", "Curso_Id");
            DropTable("dbo.Cursoes");
        }
    }
}
