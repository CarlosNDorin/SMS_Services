using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Services
{
    public  class Person
    {
        public Dictionary<string, PersonData> persons = new Dictionary<string, PersonData>();

        public Person()
        {
           // persons.Add("Disable", new PersonData { Phone ="", Description =""});
        }

        public bool newPerson(string name, string phone, string description)
        {
            if (persons.ContainsKey(name))
            {
                MessageBox.Show("ID Already exist", "Error");
                return false;
            }
            else
            {
                persons.Add(name, new PersonData {Name = name, Phone = phone, Description = description });
                return true;
            }
        }
        public void deletePerson(string name)
        {
            if(!persons.ContainsKey(name))
            {
                throw new Exception("Person not found");
            }
            persons.Remove(name);
        }
        public PersonData GetPersons(string name)
        {
            if (!persons.ContainsKey(name))
            {
                throw new Exception("Person not found");
            }
            return persons[name];

        }
        public void setPerson(string name, string nameold,string phone, string description)
        {
            if (!persons.ContainsKey(nameold))
            {
                throw new NotSupportedException("The Alarm Not Exist");
            }
            if (persons.ContainsKey(nameold))
            {
                deletePerson(nameold);
                if (persons.ContainsKey(name))
                {
                    deletePerson(name);
                }
                newPerson(name, phone, description);
            }
            else
            {
                newPerson(name,phone,description);
                deletePerson(nameold);
            }
        }
        public Dictionary<string, PersonData> getPersonsLists()
        {
            return persons;
        }
        public void setPersonsLists(Dictionary<string, PersonData> personsList)
        {
            persons = personsList;
        }

    }
    public class PersonData
    {
        public string Name;
        public string Phone;
        public string Description;
    }
}
