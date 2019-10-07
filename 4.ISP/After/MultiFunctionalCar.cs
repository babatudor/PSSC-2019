using System;

namespace After 
{
    public class MultiFunctionalCar : IMultiFunctionalVehicle 
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