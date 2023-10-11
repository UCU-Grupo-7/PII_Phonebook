using System;

namespace WhatsAppApiUCU
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatsApp = new WhatsAppApi();
            string sid = whatsApp.Send("+59899123456", "Hey there! I'm using WhatsAppUCU");
            Console.WriteLine(sid);
        }
    }
}