using CarFactory.Models;

namespace CarFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Console.Write("How many vehicles: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1 - Car");
                Console.WriteLine("2 - Truck");
                Console.WriteLine("================");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Color: ");
                    string colorChoice = Console.ReadLine();
                    Console.Write("Brand: ");
                    string brandChoice = Console.ReadLine();
                    Console.Write("Model: ");
                    string modelChoice = Console.ReadLine();
                    Cars car = new Cars(colorChoice, brandChoice, modelChoice);
                    vehicles.Add(car);
                }
                else if (choice == 2)
                {
                    Console.Write("Color: ");
                    string colorChoice = Console.ReadLine();

                    Console.Write("Brand: ");
                    string brandChoice = Console.ReadLine();
                    Console.Write("Model: ");
                    string modelChoice = Console.ReadLine();
                    Console.Write("Capacity: ");
                    float capacityChoice = float.Parse(Console.ReadLine());
                    Truck truck = new Truck(colorChoice, brandChoice, modelChoice, capacityChoice);
                    vehicles.Add(truck);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please choose 1 for Car and 2 for Truck.");
                    n++;
                }
            }

            Console.WriteLine("================");
            Console.WriteLine("Vehicle lists: ");
            Console.WriteLine("================");

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Cars)
                {
                    Cars car = (Cars)vehicle;
                    Console.WriteLine("Type: Car");
                    Console.WriteLine("Color: " + car.GetVehicleColor());
                    Console.WriteLine("Brand: " + car.GetVehicleBrand());
                    Console.WriteLine("Model: " + car.GetCarModel());
                }
                else if (vehicle is Truck)
                {
                    Truck truck = (Truck)vehicle;
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine("Color: " + truck.GetVehicleColor());
                    Console.WriteLine("Brand: " + truck.GetVehicleBrand());
                    Console.WriteLine("Model: " + truck.GetTruckModel());
                    Console.WriteLine("Capacity: " + truck.GetTruckCapacity());
                }
                Console.WriteLine("================");
            }
        }
    }
}