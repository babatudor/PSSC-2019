using System;

namespace Before 
{
    public class MultiFunctionalCar : IVehicle 
    {
        public void Drive () 
        {
            Console.WriteLine ("Driving a multifunctional car");
        }

        public void Fly () 
        {
            Console.WriteLine ("Flying a multifunctional car");
        }
    }
}