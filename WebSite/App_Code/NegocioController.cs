using CalificameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public class NegocioController : ApiController
{
    // GET api/<controller>
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    public Negocio Get(int id)
    {
        var ctx = new MyDbContext();
        var query = ctx.Negocios.Where(x => x.Id == id);
        return query.FirstOrDefault();
    }

    // POST api/<controller>
    public void Post([FromBody] Calificacion value)
    {
        var ctx = new MyDbContext();
        var query = ctx.Negocios.Where(x => x.Id == value.IdNegocio);
        var resultado = query.FirstOrDefault();

        if (resultado != null)
        {
            var comentario = new Comentario()
            {
                Calificacion = value.Valor,
                Texto = value.Comentario,
                Negocio = resultado,
                NombreUsuario = value.NombreUsuario
                //Fecha = value.Fecha
            };

            if(resultado.Comentarios == null)
                resultado.Comentarios = new List<Comentario>();

            Console.WriteLine(resultado.Comentarios.Count());

            resultado.Comentarios.Add(comentario);
            ctx.Comentarios.Add(comentario);
            ctx.SaveChanges();
        }
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
}
