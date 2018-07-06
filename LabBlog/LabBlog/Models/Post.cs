using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LabBlog.Models
{
    public class Post
    {
        [Required(ErrorMessage = "ID necesario")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo necesario")]
        public string Titulo { get; set; }
        
        public int IdCategoría { get; set; }

        [Required(ErrorMessage = "Fecha necesaria")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "Descipción necesaria")]
        public string Descripcion { get; set; }
    }
}