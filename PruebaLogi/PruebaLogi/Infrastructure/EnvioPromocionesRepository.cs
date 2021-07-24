using PruebaLogi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Infrastructure
{
    public class EnvioPromocionesRepository : IEnvioPromocionesRepository
    {
        public Hotel[] infoHotel()
        {
            // Creo los hoteles a pincho y le añado el tipo de hotel y la plantilla de mensaje. En situación real, el tipo se debería comprobar en la bdd
            // y según ese tipo tener la plantilla de mensaje definida
            Hotel[] arrayHotel = new Hotel[2];
            Hotel hotel1 = new Hotel("Iberostar playa", 1, 200, "playa", new Mensaje("Promoción de {0}. Disfruta de la playa!"), new Zona("Can Picafort", 07020));
            Hotel hotel2 = new Hotel("Palace", 2, 400, "resort", new Mensaje("Para los más exquisitos, hotel {0}."), new Zona("Palma", 07011));
            arrayHotel[0] = hotel1;
            arrayHotel[1] = hotel2;
            return arrayHotel;
        }
        public Cliente[] infoCliente()
        {
            // Creo los clientes a pincho
            Cliente[] arrayCliente = new Cliente[4];
            Cliente c1 = new Cliente("Pepe", "46883012T", 24, "", 668842019, new List<int> { 1, 1, 2 });
            Cliente c2 = new Cliente("Carla", "45113067L", 48, "carla@gmail.com", 654103548, new List<int> { 1, 2, 2, 2 });
            Cliente c3 = new Cliente("Jose", "49225613G", 89, "", 0, new List<int> { 1 });
            Cliente c4 = new Cliente("Luisa", "48226451K", 30, "luisa@gmail.com", 622349501, new List<int> { 2 });
            arrayCliente[0] = c1;
            arrayCliente[1] = c2;
            arrayCliente[2] = c3;
            arrayCliente[3] = c4;
            return arrayCliente;
        }


    }
}
