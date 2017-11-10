using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificameLibrary
{
    class MyDBContext : DbContext
    {
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        public MyDBContext() : base("name=local")
        {

        }
    }
}
