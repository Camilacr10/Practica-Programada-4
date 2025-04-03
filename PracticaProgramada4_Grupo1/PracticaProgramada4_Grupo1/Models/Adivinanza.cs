using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaProgramada4_Grupo1.Models
{
	public class Adivinanza
    {
        public string Pregunta { get; set; } //Guarda la pregunta de la adivinanza
        public string Respuesta { get; set; } //Guarda la respuesta correcta
    }

    public class RespuestaAdivinanza
    {
        public string RespuestaUsuario { get; set; } //Guarda la respuesta del usuario
    }
}