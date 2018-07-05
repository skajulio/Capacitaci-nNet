using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Almacena datos en las propiedades del modelo y las guarda en un objeto de tipo Productos
            //Products products = new Products
            //{
            //    Id = 1,
            //    Name = "Coca cola lata 235ml",
            //    Description = "Bebida sabor cola"
            //};

            ////Por medio de un objetos del tipo ProductContext toma el objeto products y las manda a la base de datos
            //using (var db = new ProductsContext())
            //{
            //    db.Products.Add(products);
            //    db.SaveChanges();
            //}

            //Imprime la información de la BD
            using (var db = new ProductsContext())
            {
                foreach(var p in db.Products)
                {
                    Console.WriteLine(p.Id);
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Description);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Producto Creado");
            Console.ReadKey();
        }
    }
}
