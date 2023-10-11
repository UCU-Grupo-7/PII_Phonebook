using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
        public void AddContact(string name)
        {
            this.persons.Add(new Contact(name));   //tiene sentido segun creator que phonebook que contiene contactos tenga su creador
        }  
    }
}


//hay que hacer seguro, agregar contacto
//quitar contacto
//enviar un mensaje a un contacto

//phonebook tiene que tener una referencia a la libreria de whatsapp api csproj





