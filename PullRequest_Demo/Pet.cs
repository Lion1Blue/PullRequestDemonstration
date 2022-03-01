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

        public Pet(Person owner)
        {
            Owner = owner;
        }

        public void ChangeOwner(Person newOwner)
        {
            Owner = newOwner;
        }
    }
}
