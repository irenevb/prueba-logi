using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string dni { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public List<int> idHotelesReservados { get; set; }
        public Cliente(string nom, string dni, int edad, string email, int tel, List<int> idHotel)
        {
            nombre = nom;
            this.dni = dni;
            this.edad = edad;
            this.email = email;
            telefono = tel;
            idHotelesReservados = idHotel;
        } // crea un cliente con sus datos básicos
    }
}
