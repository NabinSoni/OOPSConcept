using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcept
{
    interface Vehicle
    {
        void brand();
        void typeOfVehicle();
        void color()
        {
            Console.WriteLine("Blue");
        }
    }

    interface VehicleProperties
    {
        public void CarName();
    }

    class BMW : Vehicle, VehicleProperties
    {
        public void CarName()
        {
            Console.WriteLine("Car Name is BMW");
        }            

        public void brand()
        {
            Console.WriteLine("Brand Name is BMW");
        }

        public void typeOfVehicle()
        {
            Console.WriteLine("Type of Vehicle : Four Wheeler");
        }
    }
}
