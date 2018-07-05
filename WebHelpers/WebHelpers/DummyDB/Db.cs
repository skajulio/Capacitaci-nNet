using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHelpers.Models;

namespace WebHelpers.DummyDB
{
    public static class Db
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { Matricula = 123, Nombre = "Julio", Edad = 27, CurseId=1 },
            new Student { Matricula = 456, Nombre = "Jairo", Edad = 25, CurseId=1 },
            new Student { Matricula = 789, Nombre = "Franco", Edad = 21, CurseId=1 },
        };

        public static List<Curso> Cursos = new List<Curso>
        {
            new Curso { Id = 1, Nombre = "Angular"},
            new Curso { Id = 2, Nombre = "Java"},
            new Curso { Id = 3, Nombre = "C#"},
        };
    }
}