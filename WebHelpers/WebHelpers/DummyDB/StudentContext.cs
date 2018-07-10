using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebHelpers.Models;

//1.- Se instala y se importa Entity Framework
//2.- Se importan los modelos, en este caso, estudiantes
//3.- Se crea la instancia abstracta de la tabla para la base de datos

namespace WebHelpers.DummyDB
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}