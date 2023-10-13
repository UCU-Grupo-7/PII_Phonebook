using System;
using Library;
using Twilio.Rest.Notify.V1.Service;
using WhatsAppApiUCU;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Crear el contacto dueño
            Contact contactOwner = new Contact("Grupo7");
            contactOwner.Phone = "123123";
            
            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(contactOwner);
            // Agregar contactos a la lista
            Contact Nacho = new Contact("Nacho");
            phonebook.AddContact(Nacho);
            Nacho.Email = "asjknfnks@gmail.com";
            
            phonebook.PrintPhonebook();
            

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            /* var whatsApp = new WhatsAppApi();
            string sid = whatsApp.Send("+59894905570", "Hola Nano!. Estoy usando WhatsAppApiUcu");
            string sid1 = whatsApp.Send("+59899017995", "Hola Luis! Estoy usando WhatsAppApiUcu");
            string sid2 = whatsApp.Send("+59899557658", "Hola Apache! Estoy usando WhatsAppApiUcu");
            string sid3 = whatsApp.Send("+59898713002", "Hola Nacho! Estoy usando WhatsAppApiUcu"); */

            Console.WriteLine("Done");

            // Enviar un SMS a algunos contactos
        }
    }
}
