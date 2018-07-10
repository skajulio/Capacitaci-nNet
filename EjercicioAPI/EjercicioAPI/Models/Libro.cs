using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioAPI.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Paginas { get; set; }
    }
}