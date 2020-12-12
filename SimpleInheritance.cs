using System;
using System.Collections.Generic;
using System.Text;

namespace _1.OOPExample
{
    class SimpleInheritance
    {
        
        static void Main() 
        {
            Dog joe = new Dog(8, "Labrador");  //We call the constructor ! to cread new object of dog -> Object joe !
            joe.Sleep();                     // We call methods on Object joe!
            joe.WagTail();                    // we in voke methods on Object joe
            Console.WriteLine("Joe is {0} years old dog of breed {1}", 
                joe.Age, joe.Breed);
        }
         
    }
}
