using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    internal class PrivateConstructor
    {
        public static int Id { get; set; } = 1;
        public static string Name { get; set; } = "Private Constructor";

        private PrivateConstructor(){
            
        }

        public void printInfo()
        {
            Console.WriteLine($"Id is {Id}, Name is {Name}");
        }
    }
}
