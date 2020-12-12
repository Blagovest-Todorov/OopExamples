using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.OOPExample
{
    public class Creature
    {
        protected string Name { get; set; }

        public Creature() 
        {
            //Default Constructor
        }

        public Creature(string name) 
        {
            this.Name = name;   // this is addressing properties and methods iny our own class better to use 
        }                        // "this ":is the current instance of the class !this points the properties and methos of curr Object-instance
         
        private void Talk() 
        {
            Console.WriteLine("I am a creature....");
        }

        protected void Walk()  // we can use it into the this class and into the inheriting classes!
        {
            Console.WriteLine("walking .... ");
        }
    }
}
