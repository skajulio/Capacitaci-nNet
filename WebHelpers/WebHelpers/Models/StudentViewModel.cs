using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHelpers.DummyDB;

namespace WebHelpers.Models
{
    public class StudentViewModel
    {
        public Student student { get; set; }
        public List<Curso> Cursos { get; set; }

        public StudentViewModel()
        {
            using (var db = new StudentContext())
            {
                this.Cursos = db.Cursos.ToList();
            }
            //this.Cursos = Db.Cursos;
        }
    }
}