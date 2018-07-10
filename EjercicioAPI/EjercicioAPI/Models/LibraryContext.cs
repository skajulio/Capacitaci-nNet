using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjercicioAPI.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Libro> Libro { get; set; }
    }
}