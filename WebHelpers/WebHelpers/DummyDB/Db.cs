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
            new Student { Matricula = 123, Nombre = "Julio", Edad = 27 },
            new Student { Matricula = 456, Nombre = "Jairo", Edad = 25 },
            new Student { Matricula = 789, Nombre = "Franco", Edad = 21 },
        };
    }
}