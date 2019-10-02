using System;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle");

            Car car = new Car();
            car.Drive();

            Airplane airplane = new Airplane();
            airplane.Fly();

            MultiFunctionalCar mfCar = new MultiFunctionalCar(); 
            mfCar.Drive();
            mfCar.Fly();
        }
    }
}
