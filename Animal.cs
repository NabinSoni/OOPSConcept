using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    //We cannot create objet of abstract class
    abstract class Animal
    {
        public abstract void eat();
        public abstract void sleep();
        public void walk()
        {
            Console.WriteLine("Animal is walking");
        }
    }

    // Inherited class needs to implement all abstract method of Parent class
    class Dog : Animal
    {
        public void move()
        {
            Console.WriteLine("Animal is moving");
        }

        // Abstract Methods needs to be overriden
        public override void eat()
        {
            Console.WriteLine("Dog likes to eat meat");
        }

        // Abstract Methods needs to be overriden
        public override void sleep()
        {
            Console.WriteLine("Dog sleeps everytime");
        }
    }
}
