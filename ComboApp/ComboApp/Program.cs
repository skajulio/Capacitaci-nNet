using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var students = db.Student.Include("Curso").ToList();

                foreach (var student in students)
                {
                    Console.WriteLine(student.Nombre);
                    Console.WriteLine(student.Edad);
                    Console.WriteLine(student.Curso.Nombre);
                }
            }
            Console.ReadKey();
        }
    }
}
