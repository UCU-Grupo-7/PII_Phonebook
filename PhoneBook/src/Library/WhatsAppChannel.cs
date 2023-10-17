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
        string to = message.To;
        string text = message.Text;
        string m = whatsApp.Send(to, text);
    }

}