using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LabBlog.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Id Requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre Requerido")]
        public string Nombre { get; set; }
    }
}