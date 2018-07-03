using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demoMVC.Models;

namespace demoMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //ViewBag.Nombre = "Julio";
            //ViewData["Apellido"] = "Martínez";
            //ViewBag.Students = GetStudents();
            //ViewData["Students"] = GetStudents();
            return View(GetStudents());

        }

        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student{Semestre = 1, Nombre = "Julio" },
                new Student{Semestre = 2, Nombre = "Franco" },
                new Student{Semestre = 3, Nombre = "Jairo" },
            };
        }

        /*public ActionResult Index(int? number)//Se agrega (int number) para el return content. Se puede quitar para hacer funcionar el View()
        {
            Student student = new Student();
            student.Nombre = "Julio";

            if (!number.HasValue)
            {
                return HttpNotFound();
            }

            //return View(student);//Devielve la vista de estudiante
            //return RedirectToAction("Index", "Home");//Redirecciona al Home
            //return HttpNotFound();//Manda un error de página no encontrada
            return Content("Número de estudante: " + number);//Se agrega al URL /Student/?number=1 para enviar la variable
            //return Content("Hola mundo");


        }*/
    }
}