using WhatsAppApiUCU;

namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    public WhatsAppChannel()
    {

    }
    WhatsAppApi whatsApp = new WhatsAppApi();
    public void Send(Message message)
    {
        string m = whatsApp.Send(message.To, message.Text);
    }

    public Message CreateMessage(Contact contact)
    {
        WhatsAppMessage message = new WhatsAppMessage(contact);
        //message.To = contact.Phone;
        message.Text = "WhatsaApp Channel Message";

        return message;
    }
}