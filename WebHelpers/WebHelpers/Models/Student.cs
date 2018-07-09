using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebHelpers.Models
{
    public class Student
    {
        [Required(ErrorMessage = "La matricula es requerida")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "La longitud máxima es de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        public int Edad { get; set; }
        
        [Required]
        public int CurseId { set; get; }
        public Curso Curso { get; set; }
    }
}