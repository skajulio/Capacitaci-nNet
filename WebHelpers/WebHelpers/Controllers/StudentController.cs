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

        //public ActionResult Create()
        //{
        //    List<Curso> cursos = new List<Curso>
        //    {
        //        new Curso{Id=1, Nombre="Angular 1"},
        //        new Curso{Id=2, Nombre=".NET MiddleWare"},
        //        new Curso{Id=3, Nombre="Java"},
        //        new Curso{Id=4, Nombre="Node JS"},
        //        new Curso{Id=5, Nombre="Create Js"},
        //        new Curso{Id=6, Nombre="Greensock JS"},
        //        new Curso{Id=7, Nombre="Ruby"},
        //        new Curso{Id=8, Nombre="Java"},
        //        new Curso{Id=9, Nombre="Xamarin"},
        //        new Curso{Id=10, Nombre="CSS 3"},
        //    };
        //    ViewBag.Cursos = cursos;
        //    return View();
        //}

        public ActionResult Create()
        {
            StudentViewModel studentVM = new StudentViewModel();
            studentVM.Cursos = Db.Cursos;
            return View(studentVM);
        }

        [HttpPost]
        public ActionResult Create(StudentViewModel NewStudent)
        {
            if (ModelState.IsValid)
            {
                Db.Students.Add(NewStudent.student);

                return RedirectToAction("Index");
            }
            return View(NewStudent);
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
            Db.Students[index].CurseId = student.CurseId;


            return RedirectToAction("Index");
        }

        public ActionResult Delete(int matricula)
        {
            Student student = Db.Students.First(s => s.Matricula == matricula);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            Db.Students.RemoveAll(s => s.Matricula == student.Matricula);

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