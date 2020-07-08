using System;
namespace FactoryPatternVehiclesConsole
{
    public class Car : IVehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The car is Driving!!!");
        }
            
    }
}
