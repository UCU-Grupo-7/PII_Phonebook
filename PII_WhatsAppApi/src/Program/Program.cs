using System;

namespace WhatsAppApiUCU
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatsApp = new WhatsAppApi();
            string sid = whatsApp.Send("+59894905570", "Hola Nano!. Estoy usando WhatsAppApiUcu");
            string sid1 = whatsApp.Send("+59899017995", "Hola Luis! Estoy usando WhatsAppApiUcu");
            string sid2 = whatsApp.Send("+59899557658", "Hola Apache! Estoy usando WhatsAppApiUcu");
            string sid3 = whatsApp.Send("+59898713002", "Hola Nacho! Estoy usando WhatsAppApiUcu");
            Console.WriteLine(sid);
        }
    }
}