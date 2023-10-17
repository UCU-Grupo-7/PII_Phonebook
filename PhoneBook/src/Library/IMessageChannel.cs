namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);

         Message CreateMessage(Contact contact);
    }
}