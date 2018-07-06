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
        //Se comenta para implementarse en Entity Framework (Ver mas abajo)
        //public ActionResult Index()
        //{
        //    List<Student> Students = Db.Students;
        //    return View(Students);
        //}

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

        //Se comenta para trabajar este ActionResult para Entity Framework (Ver mas abajo)
        //[HttpPost]
        //public ActionResult Create(StudentViewModel NewStudent)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Db.Students.Add(NewStudent.student);

        //        return RedirectToAction("Index");
        //    }
        //    return View(NewStudent);
        //}

        //Se comenta para migrar a Entity Framework (ver mas abajo)
        //[HttpGet]//Solo por Get
        //public ActionResult Edit(int matricula)
        //{
        //    List<Student> students = Db.Students;
        //    Student student = students.First(s => s.Id == matricula);//Expresion Lambda
        //    return View(student);
        //}

        //[HttpPost]//Unicamente permite Post
        //public ActionResult Edit(Student student)
        //{
        //    int index = Db.Students.FindIndex(s => s.Id == student.Id);
        //    Db.Students[index].Nombre = student.Nombre;
        //    Db.Students[index].Edad = student.Edad;
        //    Db.Students[index].CurseId = student.CurseId;


        //    return RedirectToAction("Index");
        //}

        public ActionResult Delete(int matricula)
        {
            Student student = Db.Students.First(s => s.Id == matricula);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            Db.Students.RemoveAll(s => s.Id == student.Id);

            return RedirectToAction("Index");
        }



        //public List<Student> CrearEstudiante(int Matricula, string Nombre, int Edad)
        //{
        //    var ListaEstudiantes = GetStudents();
        //    ListaEstudiantes.Add(Matricula);
        //    return ListaEstudiantes;
        //}


        //-------------------------------- Entity Framework ------------------------------------------
        //Este s el equivalente a program en el ejercicio de DBConsole
        [HttpPost]
        public ActionResult Create(StudentViewModel NewStudent)
        {
            if (ModelState.IsValid)
            {
                using (var db = new StudentContext())
                {
                    db.Students.Add(NewStudent.student);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(NewStudent);
        }

        //Consuta a la base de datos
        public ActionResult Index()
        {
            using (var db = new StudentContext())
            {
                List<Student> ListStudents = db.Students.ToList();
                return View(ListStudents);
            }
        }


        [HttpGet]//Solo por Get
        public ActionResult Edit(int matricula)
        {
            using(var db = new StudentContext())
            {
                StudentViewModel studentVM = new StudentViewModel();
                studentVM.student = db.Students.First(s => s.Id == matricula);
                return View(studentVM);
            }
        }

        [HttpPost]//Unicamente permite Post
        public ActionResult Edit(Student student)
        {
            using(var db = new StudentContext())
            {
                Student UpdateStudent = db.Students.FirstOrDefault(s => s.Id == student.Id);
                UpdateStudent.Id = student.Id;
                UpdateStudent.Nombre = student.Nombre;
                UpdateStudent.Edad = student.Edad;
                UpdateStudent.CurseId = student.CurseId;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}