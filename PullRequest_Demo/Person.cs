using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest_Demo
{
    class Person
    {
        public string SurName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        List<Person> friends = new List<Person>();

        public Person(int age, string surName, string lastName)
        {
            Age = age;
            SurName = surName;
            LastName = lastName;
        }

        public void AddFirend(Person friend)
        {
            friends.Add(friend);
        }

        public bool RemoveFriend(Person friend)
        {
            return friends.Remove(friend);
        }
    }
}
