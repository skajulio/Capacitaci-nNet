using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboApp
{
    class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}
