namespace Library;
public class EmailChannel : IMessageChannel
{
    public EmailChannel()
    {

    }
    public void Send(Contact contact, Message message)
    {
        string to = contact.Email;
        string text = message.Text;
        
    }

}