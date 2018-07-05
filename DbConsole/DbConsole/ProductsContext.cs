using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;//Se instala desde el package maneger: Entity Framework

//Para ver la base de datos local: View/SQL Server Object Explorer
//En el explorador de Bases de datos: 
//              SQL Server/(localdb)MSSQLL/Databases/DbConsole/Tables/dbo.Productos
//              Click derecho en el nombre de la tabla/View Data

namespace DbConsole
{
    public class ProductsContext : DbContext
    {
        //Abstraccion de la base de datos (Tabla)
        public DbSet<Products> Products { get; set; }
    }
}
