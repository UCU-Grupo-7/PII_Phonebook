using System;
using System.Collections.Generic;
using Twilio.Rest.Accounts.V1.Credential;

namespace Library
{
    public class Phonebook
    {
        protected List<Contact> persons;

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
        public void Send (Contact contact, Message message)
        {

        }

        public void AddContact (Contact contact)
        {
            this.persons.Add(contact);
        }
        public void RemoveContact (Contact contact)
        {
            this.persons.Remove(contact);
        }
        public void PrintPhonebook()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i].Name);
            }
        }
        public void SendMessage (IMessageChannel channel, string[] names)
        {
            var result = Search(names);
            foreach (Contact contact in result)
            {
                Message sendMessage = channel.CreateMessage(contact);
                channel.Send(sendMessage);
            }
        } 
    }
}