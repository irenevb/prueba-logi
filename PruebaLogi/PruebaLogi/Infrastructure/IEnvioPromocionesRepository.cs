using PruebaLogi.Modelos;

namespace PruebaLogi.Infrastructure
{
    public interface IEnvioPromocionesRepository
    {
        Cliente[] infoCliente();
        Hotel[] infoHotel();
    }
}