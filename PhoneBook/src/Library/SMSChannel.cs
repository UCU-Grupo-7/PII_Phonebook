using System;
namespace Library;
public class SMSChannel : IMessageChannel
{
    public void Send(Message message)
    {
        Console.WriteLine($"SMS Sent to: {message.To}");
    }
    public Message CreateMessage(Contact contact, string text)
    {
        SMSMessage message = new SMSMessage(contact);
        message.Text = text;
        return message;
    }
}