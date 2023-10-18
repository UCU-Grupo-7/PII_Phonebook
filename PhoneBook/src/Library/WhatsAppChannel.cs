using System;
using WhatsAppApiUCU;

namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    WhatsAppApi whatsApp = new WhatsAppApi();
    public void Send(Message message)
    {
        Console.WriteLine($"WhatsApp sent to: {message.To}");
        string m = whatsApp.Send(message.To, message.Text);
    }

    public Message CreateMessage(Contact contact, string text)
    {
        WhatsAppMessage message = new WhatsAppMessage(contact);
        message.Text = text;

        return message;
    }
}