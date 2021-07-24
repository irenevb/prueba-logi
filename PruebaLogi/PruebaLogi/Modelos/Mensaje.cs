using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class Mensaje
    {
        public string plantillaMensaje { get; set; }
        public Mensaje(string plantilla)
        {
            plantillaMensaje = plantilla;
        }

    } // se crea el mensaje a través de una plantilla
}
