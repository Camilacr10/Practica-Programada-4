using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticaProgramada4_Grupo1.Models;

namespace PracticaProgramada4_Grupo1.Controllers
{

    // Controlador para manejar las adivinanzas
    public class AdivinanzasController : ApiController
    {

        // Método GET para enviar la adivinanza al usuario
        [HttpGet]
        [Route("ObtenerAdivinanza")] //Ruta de este método
        public IHttpActionResult ObtenerAdivinanza()
            {
            // Envía la pregunta de la adivinanza en formato JSON
            return Ok(new { Pregunta = "Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera." });
            }



        // Método POST para recibir la respuesta del usuario y validarla
        [HttpPost]
        [Route("ResponderAdivinanza")] //Ruta de este método
        public IHttpActionResult ResponderAdivinanza([FromBody] string respuesta) //Usa FromBody para recibir el cuerpo de la solicitud
        {
            bool correcta = respuesta.ToLower() == "la pera";//Usa ToLower() para comparar sin importar mayúsculas o minúsculas
            // Devuelve si la respuesta es correcta y muestra la correcta
            return Ok(new
            {
                Correcta = correcta,
                RespuestaCorrecta = "La pera"
            });
        }
    }
    }
