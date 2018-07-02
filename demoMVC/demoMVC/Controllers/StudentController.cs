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
            Student student = new Student();
            student.Nombre = "Julio";


            return View(student);
            //return Content("Hola mundo");


        }
    }
}