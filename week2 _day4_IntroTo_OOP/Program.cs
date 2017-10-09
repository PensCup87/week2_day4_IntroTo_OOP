using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2__day4_IntroTo_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat mittens = new Cat();//pulling information from Cat.cs Property
            mittens.Name = "Mittens";//the string is the name of this instance from the Class Cat

            Cat secondCat = new Cat("Ozzy", 2, "black");
            mittens.Eat();
            mittens.WorkOut();

            Console.WriteLine(mittens.Name);
            Console.WriteLine(secondCat.Name);
        }
    }
}
