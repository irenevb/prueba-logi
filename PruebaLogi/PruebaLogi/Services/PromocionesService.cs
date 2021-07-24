using PruebaLogi.Infrastructure;
using PruebaLogi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Services
{
    public class PromocionesService : IPromocionesService
    {
        private IEnvioPromocionesRepository ienvio;
        public PromocionesService(IEnvioPromocionesRepository i)
        {
            ienvio = i;
        }
        public Cliente[] infoCliente()
        {
            return ienvio.infoCliente();
        }
        public Hotel[] infoHotel()
        {
            return ienvio.infoHotel();
        }

    }
}
