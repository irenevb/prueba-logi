using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class TipoHotel
    {
        public string tipoHotel { get; set; }
        public Mensaje plantillaMensaje { get; set; }
        public TipoHotel(string tipo, Mensaje plantilla)
        {
            tipoHotel = tipo;
            plantillaMensaje = plantilla;
        }
    }
}
