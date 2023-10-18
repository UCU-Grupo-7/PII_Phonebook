namespace Library;

public class SMSMessage : Message
{
    public SMSMessage(Contact contact) :
        base("Grupo7", contact.Phone)
    {
        // Intencionalmente en blanco
    }
}