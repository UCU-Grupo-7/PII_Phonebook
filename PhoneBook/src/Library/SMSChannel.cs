namespace Library;
public class SMSChannel : IMessageChannel
{
    public void Send(Message message)
    {

    }

    public Message CreateMessage(Contact from, Contact to)
    {
        return new SMSMessage(to);
    }
}