using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaProgramada4_Grupo1.Models
{
	public class Adivinanza
    {
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
    }

    public class RespuestaAdivinanza
    {
        public string RespuestaUsuario { get; set; }
    }
}