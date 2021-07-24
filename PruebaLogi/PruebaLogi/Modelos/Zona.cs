using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Modelos
{
    public class Zona
    {
        public string nombreZona { get; set; }
        public int codPostal { get; set; }
        public Zona(string nombre, int codigo)
        {
            nombreZona = nombre;
            codPostal = codigo;
        } // se crea una zona con sus atributos básicos
    }
}
