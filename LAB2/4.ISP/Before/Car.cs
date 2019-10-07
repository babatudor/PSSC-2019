using System;

namespace Before 
{
    public class Car : IVehicle 
    {
        public void Drive () 
        {
            Console.WriteLine ("Driving a car");
        }

        public void Fly () 
        {
            throw new NotImplementedException ();
        }
    }
}