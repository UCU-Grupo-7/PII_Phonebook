namespace Library;

public class SMSMessage : Message
{
    public SMSMessage(Contact contact) :
        base(null, contact.Phone)
    {
        // Intencionalmente en blanco
    }
}