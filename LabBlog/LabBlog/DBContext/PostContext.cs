using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LabBlog.Models;

namespace LabBlog.DBContext
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        
    }
}