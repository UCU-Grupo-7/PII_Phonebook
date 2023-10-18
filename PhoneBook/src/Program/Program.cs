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

            // lista de nombres para mandar mensaje
            string[] list = new string[]{"Juan", "Jose", "Mateo", "Lucas", "Luis","Fernando", "Nacho", "Felipe"};
            
            // Crear el contacto dueño
            Contact contactOwner = new Contact("Grupo7");
            contactOwner.Phone = "123123";

            // Crear contactos

            Contact Juan = new Contact("Juan");
            Contact Jose = new Contact("Jose");
            Contact Mateo = new Contact("Mateo");
            Contact Lucas = new Contact("Lucas");

            Contact Luis = new Contact("Luis");
            Contact Fernando = new Contact("Fernando");
            Contact Nacho = new Contact("Nacho");
            Contact Felipe = new Contact("Felipe");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(contactOwner);
            
            // Agregar contactos a phonebook
            phonebook.AddContact(Juan);
            phonebook.AddContact(Jose);
            
            phonebook.AddContact(Luis);
            phonebook.AddContact(Fernando);
            phonebook.AddContact(Felipe);
            phonebook.AddContact(Nacho);

            
            Luis.Phone = "+59899017995";
            Fernando.Phone = "+59894905570";
            Felipe.Phone = "+59899557658";
            Nacho.Phone = "+59898713002";
            Juan.Phone = "+59899017995";
            Jose.Phone = "+59894905570";
            Mateo.Phone = "+59899557658";
            Lucas.Phone = "+59898713002";

            Luis.Email = "luis@gmail.com";
            Fernando.Email = "nano@gmail.com";
            Felipe.Email = "felipe@gmail.com";
            Nacho.Email = "nacho@gmail.com";
            Juan.Email = "juan@gmail.com";
            Jose.Email = "jose@gmail.com";
            Mateo.Email = "mateo@gmail.com";
            Lucas.Email = "lucas@gmail.com";

            // Create Message Channels & WhatsAppAPI
            WhatsAppChannel whatsAppChannel = new WhatsAppChannel();
            WhatsAppApi whatsApp = new WhatsAppApi();
            EmailChannel emailChannel = new EmailChannel();
            SMSChannel smsChannel = new SMSChannel();         

            // Enviar un correo a algunos contactos
            string[] emailList = new string[]{"Luis", "Jose", "Nacho", "Felipe"};
            phonebook.SendMessage(emailChannel, emailList, "Mensaje enviados a través de email");
            // Enviar un WhatsApp a algunos contactos
            string[] whatsList = new string[]{"Luis", "Fernando", "Nacho", "Felipe"};
            phonebook.SendMessage(whatsAppChannel, whatsList, "Your Twilio code is 1238432");   
            // Enviar un SMS a algunos contactos
            string[] smsList = new string[]{"Juan", "Fernando", "Nacho", "Lucas"};
            phonebook.SendMessage(smsChannel, smsList, "Mensaje enviado a traves de sms");

            Console.WriteLine("Done");
        }
    }
}
