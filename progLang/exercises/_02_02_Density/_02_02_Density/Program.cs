using System;

namespace _02_02_Density
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Compare the denisty of a given object to the density of water.
            Console.Write("Object's name: ");
            string objectName = Console.ReadLine();
            Console.Write("Object's volume (m3): ");
            double volume = double.Parse(Console.ReadLine());
            if (volume <= 0)
            {
                Console.WriteLine("Invalid value given for volume");
                Console.ReadLine();
                return;
            }

            Console.Write("Object's weight (g): ");
            double mass = double.Parse(Console.ReadLine());
            if (mass <= 0)
            {
                Console.WriteLine("Invalid value given for volume");
                Console.ReadLine();
                return;
            }

            double objectDensity = mass / volume;
            int waterDensity = 997000;
            Console.WriteLine("Density of {0} is {1} kg/m3.", objectName, objectDensity);

            if (objectDensity < waterDensity) Console.WriteLine("The {0} will be float on the water.", objectName);
            else if (waterDensity < objectDensity) Console.WriteLine("The {0} will be sank in the water.", objectName);
            else Console.WriteLine("The {0} will float in the water.", objectName);

            Console.ReadLine();
        }
    }
}