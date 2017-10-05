using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2__day4_IntroTo_OOP
{
    class Cat
    {
        //STATES
        //fields
        private string name;

        //properties
        //a characteristic that is an action word
        //this allows/denies code to interact with fields
        public string Name
        {
            //typical format
            get { return this.name; }
            set { this.name = value; }
        }

        
        
        //BEHAVIORS

        
        
        //CONSTRUCTORS
        public Cat()
            //A Constructor with blank () - is a default Constrcutor because it takes no
            //parameters; when the () are empty and the body can also be empty
        {

        }
    }
}
