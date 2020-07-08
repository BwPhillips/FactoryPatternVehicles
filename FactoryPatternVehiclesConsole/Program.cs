using System;

namespace FactoryPatternVehiclesConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the ammount of tires for the vehicle you want to create.");

                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
           
        }
    }
}
