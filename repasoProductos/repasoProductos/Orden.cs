using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoProductos
{
    public class Orden
    {
        public Productos productos;

        public Orden(Productos productos)
        {
            this.productos = productos;
        }

        public string Imprimir()
        {
            return $"Total de {this.productos.Nombre}: {this.productos.Precio}";
        }
    }
}
