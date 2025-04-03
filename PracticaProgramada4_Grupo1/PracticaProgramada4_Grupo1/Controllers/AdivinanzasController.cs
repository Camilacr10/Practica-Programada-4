using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticaProgramada4_Grupo1.Models;

namespace PracticaProgramada4_Grupo1.Controllers
{
    public class AdivinanzasController : ApiController
    {
            [HttpGet]
            [Route("ObtenerAdivinanza")]
            public IHttpActionResult ObtenerAdivinanza()
            {
                return Ok(new { Pregunta = "Blanca por dentro, verde por fuera. Si quieres que te lo diga, espera." });
            }




        [HttpPost]
        [Route("ResponderAdivinanza")]
        public IHttpActionResult ResponderAdivinanza([FromBody] string respuesta)
        {
            bool correcta = respuesta.ToLower() == "la pera";
            return Ok(new
            {
                Correcta = correcta,
                RespuestaCorrecta = "La pera"
            });
        }
    }
    }
