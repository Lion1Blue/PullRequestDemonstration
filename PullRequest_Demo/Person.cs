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
        public Pet Pet { get; private set; }

        List<Person> friends = new List<Person>();

        public Person(int age, string surName, string lastName, Pet pet = null)
        {
            Age = age;
            SurName = surName;
            LastName = lastName;
            Pet = pet;
        }

        public void AddFirend(Person friend)
        {
            friends.Add(friend);
        }

        public bool RemoveFriend(Person friend)
        {
            return friends.Remove(friend);
        }

        public void ChangePet(Pet newPet)
        {
            Pet = newPet;
        }
    }
}
