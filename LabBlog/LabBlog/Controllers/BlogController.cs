using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabBlog.Models;
using LabBlog.DBContext;

namespace LabBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            using (var db = new PostContext())
            {
                List<Post> ListPost = db.Posts.ToList();
                return View(ListPost);
            }
        }

        public ActionResult ControlPost()
        {
            PostViewModel PVM = new PostViewModel();
            return View(PVM);
        }

        [HttpPost]
        public ActionResult ControlPost(PostViewModel PVM)
        {
            if (PVM.post.Id == 0)
            {
                DateTime fecha = new DateTime();
                fecha = DateTime.Now.Date;
                PVM.post.Fecha = fecha.ToString("MM-dd-yyyy");

                using (var db = new PostContext())
                {
                    db.Posts.Add(PVM.post);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                using (var db = new PostContext())
                {
                    Post UpdatePost = db.Posts.FirstOrDefault(s => s.Id == PVM.post.Id);
                    UpdatePost.Titulo = PVM.post.Titulo;
                    UpdatePost.Descripcion = PVM.post.Descripcion;
                    UpdatePost.IdCategoría = PVM.post.IdCategoría;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpGet]//Solo por Get
        public ActionResult ControlPost(int? Id)
        {
            if (Id != null)
            {
                using (var db = new PostContext())
                {
                    PostViewModel PVM = new PostViewModel();
                    PVM.post = db.Posts.First(s => s.Id == Id);
                    return View(PVM);
                }
            }
            else
            {
                PostViewModel PVM = new PostViewModel();
                return View(PVM);
            }
        }

        [HttpGet]
        public ActionResult DeletePost(int Id)
        {
            using (var db = new PostContext())
            {
                PostViewModel PVM = new PostViewModel();
                PVM.post = db.Posts.First(s => s.Id == Id);
                return View(PVM);
            }
        }

        [HttpPost]
        public ActionResult DeletePost(PostViewModel PVM)
        {
            using (var db = new PostContext())
            {
                Post deletePost = db.Posts.FirstOrDefault(s => s.Id == PVM.post.Id);
                db.Posts.Remove(deletePost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}