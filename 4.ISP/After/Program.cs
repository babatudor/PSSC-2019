using System;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle");

            ICar car = new Car();
            car.Drive();

            IAirplane airplane = new Airplane();
            airplane.Fly();

            IMultiFunctionalVehicle mfCar = new MultiFunctionalCar(); 
            mfCar.Drive();
            mfCar.Fly();
        }
    }
}
