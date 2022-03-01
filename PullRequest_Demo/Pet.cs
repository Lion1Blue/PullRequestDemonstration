using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest_Demo
{
    class Pet
    {
        public Person Owner { get; private set; }
        public string name { get; private set; }
        public int Age { get; private set; }

        public Pet(Person owner, int age, string name)
        {
            Owner = owner;
            Age = age;
            this.name = name;
        }

        public void ChangeOwner(Person newOwner)
        {
            Owner = newOwner;
        }
    }
}
