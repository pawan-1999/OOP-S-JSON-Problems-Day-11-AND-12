using System;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        public static List<Inventory> inventories = new List<Inventory>();

        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            var inventories = fileReader.GetInventry();

            foreach (var i in inventories)
            {
                Console.WriteLine("Name : " + i.Name);
                Console.WriteLine("Weight : " + i.Weight);
                Console.WriteLine("Price : " + i.Price);
                Console.WriteLine("#######################");
            }

            Console.WriteLine();
            Console.WriteLine("Total price of pulses are :");
            Console.WriteLine();

            foreach (var i in inventories)
            {
                Console.WriteLine("Name: " + i.Name);
                Console.WriteLine("Total Price: " + i.Weight * i.Price);
                Console.WriteLine("************************");
            }
        }
    }
}
