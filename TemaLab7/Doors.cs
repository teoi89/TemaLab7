using System;
using System.Collections.Generic;
using System.Text;

namespace TemaLab7
{
    class Doors
    {
        private int numberOfDoors;
        public Doors(int n)
        {
            numberOfDoors = n;
        }
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }
        public void OpenTheDoors()
        {
            Console.WriteLine("click");
        }
        public void CloseTheDoors()
        {
            Console.WriteLine("clack");
        }
    }
}
