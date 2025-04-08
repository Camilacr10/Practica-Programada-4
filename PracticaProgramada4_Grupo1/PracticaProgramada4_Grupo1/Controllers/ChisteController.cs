using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PracticaProgramada4_Grupo1.Controllers
{
    // Controlador para manejar los datos curiosos
    public class ChisteController : ApiController
    {
        private static readonly List<string> Chiste = new List<string>
        {
            "—¡Camarero! Este filete tiene muchos nervios.—Pues normal… ¡es la primera vez que se lo comen!",
            "¿Cómo se llama el campeón de buceo japonés?—Tokofondo.¿Y el subcampeón?—Kasitoko.",
            "¿Qué hace una abeja en el gimnasio?—¡Zum-ba!",
            "¿Cómo se despiden los químicos?—Ácido un placer.",
            "¿Qué le dice una impresora a otra impresora?—¿Esa hoja es tuya o es una impresión mía?"
        };

        private static readonly Random rng = new Random();

        // Método GET para obtener el chiste
        [HttpGet]
        [Route("ObtenerChiste")] // Ruta para obtener el chiste
        public IHttpActionResult ObtenerChiste()
        {
            int indice = rng.Next(Chiste.Count);
            return Ok(new { Mensaje = Chiste[indice] });
        }
    }
}