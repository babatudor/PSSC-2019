using System;

namespace After
{
    public class Car : ICar
    {
        public void Drive()
        {      
            Console.WriteLine("Driving a car");
        }
    }
}