using PruebaLogi.Modelos;
using PruebaLogi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestPruebaLogi.Infrastructure
{
    public class EnvioPromocionesRepositoryTest
    {
        [Fact]
        public void validate_infoHotelNotNull()
        {
            var repository = new EnvioPromocionesRepository();
            Hotel[] hoteles = repository.infoHotel();
            Assert.NotNull(hoteles);
        }
    }
}
