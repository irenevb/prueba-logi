using Microsoft.AspNetCore.Mvc;
using PruebaLogi.Modelos;
using PruebaLogi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaLogi.Controllers
{
    [Route("api/[controller]")]
    public class EnvioPromocionesController : Controller
    {
        private IPromocionesService ipromo;
        public EnvioPromocionesController(IPromocionesService i)
        {
            ipromo = i;
        }
        [HttpGet]
        public List<string> enviarMensajes()
        {
            Hotel[] hoteles = ipromo.infoHotel(); // coge toda la información de los hoteles que tiene
            Cliente[] clientes = ipromo.infoCliente(); // coge toda la información de los clientes
            List<string> resp = new List<string>();
            for (int i = 0; i < clientes.Length; i++) // envía un mensaje a todos los clientes
            {
                var r = enviarMensaje(clientes[i], hoteles);
                if (r != "")
                {
                    resp.Add(r); // cuando se consigue crear emails o sms, se van añadiendo a la lista de envío
                }

            }

            //Se deberia llamar a un método del service para que enviase los mensajes a través del repositorio.
            return resp;
        }
        private string enviarMensaje(Cliente c, Hotel[] hoteles) // encargado de enviar el mensaje a un cliente concreto
        {
            Hotel hotelProm = hotelPromo(c, hoteles); // de ese cliente, escoge el hotel que quiere promocionar
            string respuesta = "";
            if (hotelProm != null) // si tenemos el hotel
            {
                string msg = String.Format(hotelProm.plantillaMensaje.plantillaMensaje, hotelProm.nombreHotel); // coge la plantilla que le corresponde a ese hotel
                if (c.email != "") // preferimos enviar el email si se tiene su correo 
                {
                    Email correo = new Email(c.email, msg); // creal el email con ese mensaje
                    string mensajeF = $"Mensaje enviado correctamente a {c.nombre} con correo: {c.email}. Mensaje enviado: " + msg;
                    Console.WriteLine(mensajeF);
                    respuesta = mensajeF; // simulamos el envío del correo mostrándolo por pantalla

                }
                else if (c.telefono > 0) // si no tenemos el correo, pero sí el teléfono, procedemos a intentar enviarle un sms
                {
                    Sms sms = new Sms(c.telefono, msg); // con el mensaje de promo creado, creamos un nuevo sms
                    string mensajeF = $"Mensaje enviado correctamente a {c.nombre} con teléfono: {c.telefono}. Mensaje enviado: " + msg;
                    Console.WriteLine(mensajeF);
                    respuesta = mensajeF; // simulamos el envío del sms mostrándolo por pantalla
                }
            }
            return respuesta; // si no tiene email ni sms, devolverá un null
        }
        private Hotel hotelPromo(Cliente k, Hotel[] h)
        {
            List<int> idhotelesReservados = k.idHotelesReservados;
            if (idhotelesReservados.Count > 0) // si ese cliente ha reservado algún hotel
            {
                List<Zona> zonas = new List<Zona>();
                int[] hotelesreservados = k.idHotelesReservados.ToArray();
                for (int i = 0; i < hotelesreservados.Length; i++) // de cada uno de los hoteles reservados, buscamos la zona
                {
                    Hotel hotelReservado = h.ToList().Find(z => z.idHotel == hotelesreservados[i]);
                    zonas.Add(hotelReservado.zona);
                }
                var zonaMasReservada = zonas // de todas las zonas recopiladas, cogemos la más reservada
                          .GroupBy(z => z)
                          .OrderByDescending(g => g.Count())
                          .Select(g => g.Key)
                          .First();
                var hotelPromocion = h.ToList().Find(hotel => hotel.zona == zonaMasReservada); // el hotel que se promocionará es aquel que se encuentre en la zona donde el cliente ha reservado más veces
                return hotelPromocion;
            }
            return null;
        }
    }
}



