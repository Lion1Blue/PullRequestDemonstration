using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest_Demo
{
    class House
    {
        List<Person> residents = new List<Person>();

        public House(List<Person> residents)
        {
            this.residents = residents;
        }

        public void AddResidents(Person person)
        {
            residents.Add(person);
        }

        public bool RemoveResidents(Person person)
        {
            return residents.Remove(person);
        }
    }
}
