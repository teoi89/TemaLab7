using System;
using System.Collections.Generic;
using System.Text;

namespace TemaLab7
{
    class Car
    {
        private readonly string brand;
        private readonly string carModel;
        private readonly int manufactYear;
        private Doors doors;
        private Engine engine;
        public Car(string brand, string model, int year, int numberOfDoors)
        {
            this.brand = brand;
            carModel = model;
            manufactYear = year;
            this.doors = new Doors(numberOfDoors);
        }
        public void OpenAllDoors()
        {
            this.doors.OpenTheDoors();
        }
        public void CloseAllDoors()
        {
            this.doors.CloseTheDoors();
        }
        public void StartTheEngine()
        {
            Console.WriteLine("The car started.");
        }
        public void StopTheEngine()
        {
            Console.WriteLine("The car stopped.");
        }

        public void PrintDescription()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {carModel}");
            Console.WriteLine($"Manufacturing year: {manufactYear}");
        }
        public void GetTheCarRunning()
        {
            StartTheEngine();
            CloseAllDoors();
        }
        public void MakeTheCarStop()
        {
            StopTheEngine();
            OpenAllDoors();
        }
    }
}
