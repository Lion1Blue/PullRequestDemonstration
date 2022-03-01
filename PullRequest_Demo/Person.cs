using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest_Demo
{
    class Person
    {
        public string Vorname { get; private set; }
        public string Nachname { get; private set; }
        public int Alter { get; private set; }
        public Pet Pet { get; private set; }

        List<Person> friends = new List<Person>();
       

        public Person(int alter, string vorname, string nachname, Pet pet = null)
        {
            Alter = alter;
            Vorname = vorname;
            Nachname = nachname;
            Pet = pet;
        }

        public void AddFirend(Person person)
        {
            friends.Add(person);
        }

        public bool RemoveFriend(Person person)
        {
            return friends.Remove(person);
        }
    }
}
