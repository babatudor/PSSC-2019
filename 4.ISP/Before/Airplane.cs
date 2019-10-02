using System;

namespace Before
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
 
        public void Fly()
        {
            Console.WriteLine("Flying a plane");
        }   
    }
}