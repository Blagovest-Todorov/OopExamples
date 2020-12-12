using System;
using System.Collections.Generic;
using System.Text;

namespace _1.OOPExample
{
    class InheritanceAndAccessibility
    {

        static void Main() 
        {
            Dog joe = new Dog ("Sharo", 6, "Labrador");
            joe.Sleep();
            Console.WriteLine("Breed:"  + joe.Breed);
            joe.WagTail();

            Dog dog = new Dog()
            {
                Age = 4,
                Breed = ""

            };
            


            // joe.Talk(); Talk is private in  Craeture class, not accessible here // not compiled
            // joe.Walk();is protected --level of access is restrigted to base class and fits inheriting, this is second level of inheriting
            // not compiled too / // Walk is accessible into the intermediang middle class -Mamamal!
            // Console.WriteLine("Name: " + joe.Name); -property-protected and not visible here, visible in intermediaty class -Mammal
        }
    }
}
