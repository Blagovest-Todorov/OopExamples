using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.OOPExample
{
    public class Dog : Mammal // class corresponds with the fileName!
    {
        
        public string Breed { get; private set; }  // is set is private - we cant modify  the breed

        public Dog() 
        {
           //default constructor
        }
        public Dog(string name, int age, string breed) : base(name, age)   // constructor inherits from base class constructor so we call base class constructor!
        {
            this.Breed = breed;
            //this.Sleep(Console.WriteLine("Dont sleep now"));
        }

        //public void Sleep() - if we define it here and call the output content will replace the same method content in base class
        //{
        //    Console.WriteLine("Dont Sleep");
        //}
        // base Talk() can not be invoked here -it is private 


        public void WagTail() 
        {
            Console.WriteLine("Tail waggling ...");
        }
         // program does not have ab ebtry point, a method main it it !!
    }
}
