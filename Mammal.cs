using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.OOPExample
{
    public class Mammal
    {
        public int Age { get; set; }
        public Mammal(int age) 
        {
            this.Age = age;
        }
        public void Sleep() 
        {
            Console.WriteLine("shhtt , i am sleepuing!");
          
        }
         // program does not contain an entry pioint !
        
    }
}
