using System;
namespace FactoryPatternVehiclesConsole
{
    public class ThreeWheeler : IVehicle
    {

        public void Drive()
        {
            Console.WriteLine("Lets go!!!");
        }
    }
}
