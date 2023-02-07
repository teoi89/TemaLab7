using System;
using System.Collections.Generic;
using System.Text;

namespace TemaLab7
{
    class Engine
    {
        private int cilindricalCapacity;
        private int horsePower;
        private string fuelType;
        public Engine(int cc, int horesePower, string fuel)
        {
            cilindricalCapacity = cc;
            this.horsePower = horesePower;
            fuelType = fuel;
        }
        public int CilindricalCapacity
        {
            get { return cilindricalCapacity; }
            set { cilindricalCapacity = value; }
        }
        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public void StartEngine()
        {
            Console.WriteLine("brr");
        }
        public void StopEngine()
        {
            Console.WriteLine("par poc pac");
        }
    }
}
