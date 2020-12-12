using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.OOPExample
{
    public class Dog : Mammal // class corresponds with the fileName!
    {
        
        public string Breed { get; set; }
        public Dog(int age, string breed) : base(age)   // constructor inherits from base class constructor so we call base class constructor!
        {
            this.Breed = breed;
        }


        public void WagTail() 
        {
            Console.WriteLine("Tail waggling ...");
        }
         // program does not have ab ebtry point, a method main it it !!
    }
}
