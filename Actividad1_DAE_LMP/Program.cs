using System;

namespace Actividad1_DAE_LMP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring arrays
            string[] name = new string[10];
            int[] quantity = new int[10];
            double[] price = new double[10];

            // Filling the arrays
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Welcome to Diego's Shop!\n");
                Console.WriteLine($"Enter the name product {i+1}: ");
                name[i] = Console.ReadLine();
                Console.WriteLine($"Enter how many {name[i]} you want: ");
                quantity[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the price product {i+1}: ");
                Console.Write("$");
                price[i] = double.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
