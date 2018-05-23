using System;

namespace Carfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(5, 5, "Blue", "Peugeot", "308");
            var hatchback = new Hatchback("Blue", "Peugeot", "308");

            Console.WriteLine($"Car: {car}");
            Console.WriteLine($"Hatchback: {hatchback}");

            Console.ReadLine();
        }
    }
}
