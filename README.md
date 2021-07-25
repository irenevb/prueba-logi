# Prueba Logitravel Irene Vera
Logitravel desea enviar a sus clientes un e-mail o sms, según los datos y preferencia de cada cliente, promocionando hoteles de la misma zona a los que ha contratado. Cada cliente ha podido reservar varios hoteles y cada tipo de hotel requiere una plantilla de mensaje diferente.

● Diagrama de clases necesario para llevar a cabo una implementación del escenario anterior:

![Prueba Logitravel (2)](https://user-images.githubusercontent.com/44347390/126896177-ce7b044d-d6f7-449e-bbe6-0c4caf1dee45.png)

● Proyecto con implementación en C#.

# Principales módulos
## EnvioPromocionesController

Permite enviar los mensajes a cada uno de los clientes teniendo en cuenta en qué zona ha reservado más hoteles. De esta forma, elige qué hotel debe promocionarse.

## EnvioPromocionesRepository

Se crea a "pincho" los hoteles y los clientes.

## Hotel

Clase hotel, necesita la zona y el tipo de hotel (necesario para saber qué plantilla de mensaje utilizar).

## Cliente

Clase Cliente, si no carga un email o un teléfono, no se le podrá enviar ninguna promoción.

## Mensaje

Contiene la plantilla del mensaje. Es la clase padre de SMS y EMAIL.

## SMS / EMAIL

La diferencia es que uno necesita de un teléfono para hacer el envío y el otro un correo electrónico.

## TEST UNITARIOS

En TestPruebaLogi se ha hecho una prueba para comprobar que se devuelven correctamente los hoteles.

# ANOTACIONES

**No se ha creado la clase reserva para simplificar el programa.**

La ejecución de la solución hace una llamada y muestra en el navegador al darle a ejecutar los Mensajes impresos por pantalla, también puede verse desde la consola de Visual Studio.

![image](https://user-images.githubusercontent.com/44347390/126870866-5f820108-007e-4fe7-9aa9-2c999a174094.png)


Si se ejecuta el test podemos ver que funciona correctamente:

![image](https://user-images.githubusercontent.com/44347390/126870861-1dbdab24-eeec-473c-a9f4-7549226fa26d.png)
