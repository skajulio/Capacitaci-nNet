namespace ComboApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearCursos : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Cursoes (Nombre) values ('Java');");
            Sql("insert into Cursoes (Nombre) values ('.Net');");
            Sql("insert into Cursoes (Nombre) values ('Bootstrap');");
            Sql("insert into Cursoes (Nombre) values ('Angular');");
            Sql("insert into Cursoes (Nombre) values ('Create Js');");
            Sql("insert into Cursoes (Nombre) values ('C#');");
        }
        
        public override void Down()
        {
        }
    }
}
