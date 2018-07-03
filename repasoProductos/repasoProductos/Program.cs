using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Productos> misProductos = new List<Productos>();

            Productos productos1 = new Productos();
            Productos productos2 = new Productos();
            Productos productos3 = new Productos();
            Productos productos4 = new Productos();

            productos1.Nombre = "Libro";
            productos2.Nombre = "Botella";
            productos3.Nombre = "Agua";
            productos4.Nombre = "Refresco";

            productos1.Id = 1;
            productos2.Id = 2;
            productos3.Id = 3;
            productos4.Id = 4;

            productos1.Descripcion = "Pasta blanda";
            productos2.Descripcion = "Pet";
            productos3.Descripcion = "Bonafont";
            productos4.Descripcion = "Cocacola";

            productos1.Precio = 90.00;
            productos2.Precio = 10.50;
            productos3.Precio = 12;
            productos4.Precio = 12.5;

            misProductos.Add(productos1);
            misProductos.Add(productos2);
            misProductos.Add(productos3);
            misProductos.Add(productos4);

            foreach(Productos p in misProductos)
            {
                Orden ordenes = new Orden(p);
                Console.WriteLine("ID:\t\t" +p.Id);
                Console.WriteLine("Nombre:\t\t"+p.Nombre);
                Console.WriteLine("Descripción:\t"+p.Descripcion);
                Console.WriteLine("Precio:\t" + p.Precio);
                ImprimirEnConsola(ordenes.Imprimir() + "\n");
            }

            Orden orden = new Orden(productos1);

            string CadenaAImprimir = orden.Imprimir();
            ImprimirEnConsola(CadenaAImprimir);

            Console.ReadKey();
        }

        public static void ImprimirEnConsola(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
