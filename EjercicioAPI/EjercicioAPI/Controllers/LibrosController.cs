using EjercicioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EjercicioAPI.Controllers
{
    public class LibrosController : ApiController
    {
        private LibraryContext context;

        public LibrosController()
        {
            context = new LibraryContext();
        }

        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return context.Libro.ToList();
        }

        [HttpGet]
        public Libro Get(int Id)
        {
            var libro = context.Libro.Find(Id);
            if (libro == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return libro;
        }

        [HttpPost]
        public Libro Create(Libro libro)
        {
            var createLibro = context.Libro.Add(libro);
            context.SaveChanges();
            return libro;
        }

        [HttpPut]
        public Libro Update(int Id, Libro libro)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var libroToUpdate = context.Libro.Find(Id);

            if (libroToUpdate == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            libroToUpdate.Autor = libro.Autor;
            libroToUpdate.Descripcion = libro.Descripcion;
            libroToUpdate.Editorial = libro.Editorial;
            libroToUpdate.Paginas = libro.Paginas;
            libroToUpdate.Titulo = libro.Titulo;

            context.SaveChanges();

            return libroToUpdate;
        }

        [HttpDelete]
        public void Delete(int Id)
        {
            var libroToDelete = context.Libro.Find(Id);

            if (libroToDelete == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            context.Libro.Remove(libroToDelete);

            context.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}
