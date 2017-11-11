using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificameLibrary
{
    public class Comentario
    {
        public int Id { get; set; }
        public double Calificacion { get; set; }
        public string Texto { get; set; }
        public Negocio Negocio { get; set; }
        public string  NombreUsuario { get; set; }
        //public DateTime Fecha { get; set; }
    }
}
