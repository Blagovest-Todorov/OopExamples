using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.OOPExample
{
    public class Mammal : Creature
    {
        public int Age { get; set; }

        public Mammal() 
        {
            //Default constructor
        }
        public Mammal(string name, int age) : base(name)
        {
            this.Age = age;
        }
        public void Sleep()   // sleep method exists only in the Base class Mammal 
        {
            Console.WriteLine("shhtt {0}, i am sleeping!", this.Name);
          
        }
         // program does not contain an entry pioint !
        // base Talk()  cant be invoked here , its private declared into base class
        // this Name can be read but cannot be modified hier -marked as protected in Base Class Creature
    }
}
