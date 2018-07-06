using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabBlog.DBContext;

namespace LabBlog.Models
{
    public class PostViewModel
    {
        public Post post { get; set; }
        private Categoria categoria { get; set; }
        public List<Categoria> ListaCategorias { get; set; }
        public PostViewModel()
        {
            //------------------------------------- Descomentar Cuando se ejecute por primera Vez ----------------
            //----------------------------------- Para generar la tabla Categoría en la Base de Datos ------------
            //Categoria NewCategoria = new Categoria();
            //NewCategoria.Id = 1;
            //NewCategoria.Nombre = "Perlícula de Accion";
            //using (var db = new PostContext())
            //{
            //    db.Categorias.Add(NewCategoria);
            //    db.SaveChanges();
            //}

            //NewCategoria.Id = 2;
            //NewCategoria.Nombre = "Perlícula de CiFi";
            //using (var db = new PostContext())
            //{
            //    db.Categorias.Add(NewCategoria);
            //    db.SaveChanges();
            //}

            //NewCategoria.Id = 3;
            //NewCategoria.Nombre = "Perlícula de Fantasía";
            //using (var db = new PostContext())
            //{
            //    db.Categorias.Add(NewCategoria);
            //    db.SaveChanges();
            //}

            //NewCategoria.Id = 4;
            //NewCategoria.Nombre = "Perlícula de Drama";
            //using (var db = new PostContext())
            //{
            //    db.Categorias.Add(NewCategoria);
            //    db.SaveChanges();
            //}

            //NewCategoria.Id = 5;
            //NewCategoria.Nombre = "Perlícula de Documental";
            //using (var db = new PostContext())
            //{
            //    db.Categorias.Add(NewCategoria);
            //    db.SaveChanges();
            //}

            using (var db = new PostContext())
            {
                this.ListaCategorias = db.Categorias.ToList();
            }

        }
    }
}