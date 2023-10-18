using System;
namespace Library;
public class EmailChannel : IMessageChannel
{
    public void Send(Message message)
    {
        Console.WriteLine($"Email Sent to: {message.To}");
    }
    public Message CreateMessage(Contact contact, string text)
    {
        EmailMessage message = new EmailMessage(contact);
        message.Text = text;
        return message;
    }

}