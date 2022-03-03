using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest_Demo
{
    class Cat : Pet
    {
        public Cat(Person owner = null) : base(owner)
        {
            //bla bla
        }

        public new int Age { get { return Age * 7; } private set { Age = value; }}

    }
}
