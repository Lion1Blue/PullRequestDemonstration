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

        List<Person> freunde = new List<Person>();

        public Person(int alter, string vorname, string nachname)
        {
            Alter = alter;
            Vorname = vorname;
            Nachname = nachname;
        }

        public void AddFreund(Person person)
        {
            freunde.Add(person);
        }
    }
}
