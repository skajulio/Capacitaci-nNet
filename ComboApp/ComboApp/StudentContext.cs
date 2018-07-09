using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ComboApp
{
    class StudentContext: DbContext
    {
        public DbSet<Student> Student { get; set; }
    }
}
