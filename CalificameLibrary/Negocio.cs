using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificameLibrary
{
    class Negocio
    {
        public int Id { get; set; }
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}
