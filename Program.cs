using System;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.PenId = 1;
            pen.PenType = "Ball";
            pen.PenColor = "Blue";

            pen.setPenWidth(24);          
            penInfo();


            void penInfo()
            {
                Console.WriteLine($"Pen Id is {pen.PenId}, \n" +
                    $"Pen Type is {pen.PenType}, \n" +
                    $"Pen Color is {pen.PenColor}, \n" +
                    $"Pen Width is {pen.getPenWidth()},\n"+
                    $"Pen Height is {pen.getPenHeight()}");
            }
            //pen.penInfo();
            Console.WriteLine("Hello World!");

        }
    }
}
