![UCU](https://github.com/ucudal/PII_Conceptos_De_POO/raw/master/Assets/logo-ucu.png)

## FIT - Universidad Católica del Uruguay

### Programación II

# API de WhatsApp

API para enviar mensajes por WhatsApp (usando Twilio).

Para poder enviar mensajes por WhatsApp, una vez agregada la libreria a su proyecto como referencia,
podrán hacer uso del siguiente código de ejemplo:

```c#
var whatsApp = new WhatsAppApi();
whatsApp.Send("+598<Poné tu teléfono acá>", "Hey! I'm using WhatsApp");
```

- Reemplazar ``"<Poné tu teléfono acá>"`` por el número de teléfono de ustedes.

- Agregar a WhatsApp el siguiente contacto: +14155238886

- Enviar al nuevo contacto (+14155238886) el siguiente mensaje: `join poetry-naturally`

:warning: Estamos usando una cuenta gratuita de Twilio que permite enviar una cantidad limitada de mensajes. Por favor usa esta funcionalidad con discreción y sólo para los ejercicios del curso.

> Los repositorios que usan esta librería asumen que fueron descargados en la misma carpeta 'madre'.