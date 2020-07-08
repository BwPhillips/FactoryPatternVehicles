using System;
namespace FactoryPatternVehiclesConsole
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The Motorcyle is revving up!!!");
            Console.WriteLine("Boom");
        }
    }
}
