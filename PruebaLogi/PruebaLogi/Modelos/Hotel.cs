using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class Hotel : TipoHotel
    {
        public string nombreHotel { get; set; }
        public int idHotel { get; set; }
        public double precioHotel { get; set; }
        public Zona zona { get; set; }
        public Hotel(string n, int id, int precio, string tipo, Mensaje mensaje, Zona zona)
            : base(tipo, mensaje)
        {
            nombreHotel = n;
            idHotel = id;
            precioHotel = precio;
            this.zona = zona;
        } // se crea el hotel con sus atributos básicos. Según el tipo de hotel, se tiene una plantilla de mensaje u otra

    }
}
