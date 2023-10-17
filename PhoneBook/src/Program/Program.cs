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
            string[] list = new string[]{"Luis", "Fernando", "Nacho", "Felipe"};
            
            // Crear el contacto dueño
            Contact contactOwner = new Contact("Grupo7");
            contactOwner.Phone = "123123";

            // Crear contactos

            Contact Juan = new Contact("Juan");
            Contact Jose = new Contact("Jose");

            Contact Luis = new Contact("Luis");
            Contact Fernando = new Contact("Fernando");
            Contact Nacho = new Contact("Nacho");
            Contact Felipe = new Contact("Felipe");

           /*  list.Add(Felipe.Name);
            list.Add(Fernando.Name);
            list.Add(Luis.Name);
            list.Add(Nacho.Name); */

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

            Luis.Email = "luis@gmail.com";
            Fernando.Email = "nano@gmail.com";
            Felipe.Email = "felipe@gmail.com";
            Nacho.Email = "nacho@gmail.com";



            var result = phonebook.Search(list);

            foreach (Contact per in result)
            {
                Console.WriteLine(per.Name);
                Console.WriteLine(per.Phone);
                Console.WriteLine(per.Email);
                
            }

            // Agregar contactos a la lista
/*             Contact Nacho = new Contact("Nacho");
            phonebook.AddContact(Nacho);
            Nacho.Email = "asjknfnks@gmail.com"; */
            
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
