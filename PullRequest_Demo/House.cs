using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest_Demo
{
    class House
    {
        public string Adress { get; private set; }
        List<Person> residents = new List<Person>();

        public House(List<Person> residents)
        {
            this.residents = residents;
        }

        public void AddResident(Person resident)
        {
            residents.Add(resident);
        }

        public bool RemoveResident(Person resident)
        {
            return residents.Remove(resident);
        }
    }
}
