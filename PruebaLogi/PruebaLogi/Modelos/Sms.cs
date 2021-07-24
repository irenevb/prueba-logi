using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class Sms : Mensaje
    {
        public int telefono { get; set; }
        public Sms(int tel, string plantilla) : base(plantilla)
        {
            telefono = tel;
        } // se crea un sms a partir del teléfono del cliente y el mensaje


    }
}
