using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelpers.Models;
using WebHelpers.DummyDB;

namespace WebHelpers.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> Students = Db.Students;
            return View(Students);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student NewStudent)
        {
            Db.Students.Add(NewStudent);

            return RedirectToAction("Index");
        }

        [HttpGet]//Solo por Get
        public ActionResult Edit(int matricula)
        {
            List<Student> students = Db.Students;
            Student student = students.First(s => s.Matricula == matricula);//Expresion Lambda
            return View(student);
        }

        [HttpPost]//Unicamente permite Post
        public ActionResult Edit(Student student)
        {
            int index = Db.Students.FindIndex(s => s.Matricula == student.Matricula);
            Db.Students[index].Nombre = student.Nombre;
            Db.Students[index].Edad = student.Edad;

            
            return RedirectToAction("Index");
        }

        //public List<Student> CrearEstudiante(int Matricula, string Nombre, int Edad)
        //{
        //    var ListaEstudiantes = GetStudents();
        //    ListaEstudiantes.Add(Matricula);
        //    return ListaEstudiantes;
        //}
    }
}