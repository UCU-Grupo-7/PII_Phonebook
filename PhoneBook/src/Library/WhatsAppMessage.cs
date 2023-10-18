namespace Library;

public class WhatsAppMessage : Message
{
    public WhatsAppMessage(Contact contact) :
        base("Grupo7", contact.Phone)
    {
        // Intencionalmente en blanco

    }
}