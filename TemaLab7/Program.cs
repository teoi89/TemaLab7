using System;

namespace TemaLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the details of car 1");
            Console.WriteLine("Brand:");
            string brand1 = Console.ReadLine();
            Console.WriteLine("Model:");
            string carModel1 = Console.ReadLine();
            Console.WriteLine("Fuel type:");
            string fuelType1 = Console.ReadLine();
            Console.WriteLine("Manufacturing year:");
            int manufactYear1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Engin capacity:");
            int cilindricalCapacity1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Horse power:");
            int horsePower1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of doors:");
            int numberOfDoors1 = int.Parse(Console.ReadLine());

            /*Console.WriteLine("Enter the details of car 2");
            Console.WriteLine("Brand:");
            string brand2 = Console.ReadLine();
            Console.WriteLine("Model:");
            string carModel2 = Console.ReadLine();
            Console.WriteLine("Fuel type:");
            string fuelType2 = Console.ReadLine();
            Console.WriteLine("Manufacturing year:");
            int manufactYear2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Engin capacity:");
            int cilindricalCapacity2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Horse power:");
            int horsePower2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of doors:");
            int numberOfDoors2 = int.Parse(Console.ReadLine());*/

            Engine engine1 = new Engine(cilindricalCapacity1, horsePower1, fuelType1);
            Car car1 = new Car(brand1, carModel1, manufactYear1, numberOfDoors1);
            car1.PrintDescription();
            car1.GetTheCarRunning();
            car1.MakeTheCarStop();
            Console.WriteLine();

            /*Engine engine2 = new Engine(cilindricalCapacity2, horsePower2, fuelType2);
            Car car2 = new Car(brand2, carModel2, manufactYear2, numberOfDoors2);
            car2.PrintDescription();
            car2.GetTheCarRunning();
            car2.MakeTheCarStop();
            Console.WriteLine();*/
        }
    }
}
