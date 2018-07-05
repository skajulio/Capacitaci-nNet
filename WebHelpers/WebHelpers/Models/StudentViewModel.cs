using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHelpers.Models
{
    public class StudentViewModel
    {
        public Student student { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}