namespace Library;

public class EmailMessage : Message
{
    public EmailMessage(Contact contact) :
        base("grupo7@ucu.edu.uy", contact.Email)
    {
        // Intencionalmente en blanco
    }
}