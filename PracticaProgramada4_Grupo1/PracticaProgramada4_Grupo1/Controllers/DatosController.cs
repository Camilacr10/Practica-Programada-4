using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PracticaProgramada4_Grupo1.Controllers
{
    // Controlador para manejar los datos curiosos
    public class DatosController : ApiController
    {
        private static readonly List<string> Datos = new List<string>
        {
            "El primer avión voló el 17 de diciembre de 1903.",
            "La probabilidad de que exista una langosta azul es de una entre dos millones.",
            "Se puede escuchar el latido de una ballena azul a más de 3 kilómetros de distancia.",
            "Una gota de petróleo puede contaminar 25 litros de agua.",
            "Es imposible estornudar con los ojos abiertos."
        };

        private static readonly Random rng = new Random();

        // Método GET para obtener un dato curioso
        [HttpGet]
        [Route("ObtenerDato")] // Ruta para obtener el dato curioso
        public IHttpActionResult ObtenerDato()
        {
            int indice = rng.Next(Datos.Count);
            return Ok(new { Mensaje = Datos[indice] });
        }
    }
}