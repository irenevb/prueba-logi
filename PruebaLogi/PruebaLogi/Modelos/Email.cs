using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class Email : Mensaje
    {
        public string email { get; set; }
        public Email(string email, string plantilla) : base(plantilla)
        {
            this.email = email;
        } // Se crea un email a través del mensaje y el correo del cliente



    }
}
