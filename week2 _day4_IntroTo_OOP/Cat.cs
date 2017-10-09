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
        
        //Fields - class characteristic of the class that are built in by coder
        //these attributes are exhibited by an actual cat(or other object)
        //values can be set in this section or they can be set later
        //access comes from properties of the "CAt" program
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;//("everytime we have a cat, the cat is hungry")


        //properties
        //a characteristic that is an action word; allow access to the field
        //.Length is a property
        //this allows/denies code to interact with fields
        //change info in properties before changing in Fields
        public string Name
        {
            //typical format
            get { return this.name; }//allows access to the properties in the Field
            set { this.name = value; }//set allows you to set the values in the Field
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        
        
        //BEHAVIORS

        
        
        //CONSTRUCTORS  -Create a New Instance of the Object
        public Cat()
        { 
            //A Constructor with blank () - is a default Constrcutor because it takes no
            //parameters; when the () are empty and the body can also be empty
            //NEED Both this constructor and the next one
            //this is the default constructor
            //THE DEFAULT HAS TO HAVE BLANK ()
         }


        public Cat(string name, int age, string furColor)
            //overloaging a constrcutor - giving different parameters; creates a new object and assigning the values right away.
            //bypasses the need for properties
            //a constructor is a type of method
            //this method makes a Cat obect, with the values being defined
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Classes have Methods (Constructor is a Method)
        public void Eat()
        {
            if(isHungry == true)
            {
                isHungry = false;//checks if isHungry then changes it to false
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }

    }
}
