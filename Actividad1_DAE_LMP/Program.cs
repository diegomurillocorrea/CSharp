using System;

namespace Actividad1_DAE_LMP
{
    class Program
    {
        static void Main(string[] args) {
            Program program = new Program();
            program.Exercise2();
        }

        public void Exercise1() {
            int limit = 0;
            Console.Write("Enter an amount: ");
            limit = int.Parse(Console.ReadLine());

            Console.Clear();
            // Declaring arrays
            string[] name = new string[limit];
            int[] amount = new int[limit];
            double[] price = new double[limit];
            double total_price = 0;

            // Filling the arrays
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Welcome to Diego's Shop!\n");
                Console.WriteLine($"Enter the product name {i + 1}: ");
                name[i] = Console.ReadLine();
                Console.WriteLine($"Enter the amount of {name[i]} you want: ");
                amount[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the product price {i + 1}: ");
                Console.Write("$");
                price[i] = double.Parse(Console.ReadLine());
                total_price += price[i];
                Console.Clear();
            }

            Console.WriteLine($"These are the products you entered\n");
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Product\t\t\t amount\t\t Price");
                Console.WriteLine($"{name[i]}\t\t\t {amount[i]}\t\t\t {price[i]}");
            }
            Console.Write($"\nThe total price including the IVA 13% is: ${Math.Round(total_price + (total_price * 0.13), 2)}");
            Console.WriteLine("\nThanks for choosing Diego's shop!");
        }

        public void Exercise2 () {
            int limit = 0;
            Console.Write("Enter an amount: ");
            limit = int.Parse(Console.ReadLine());

            string[] employee_name = new string[limit];
            string[] employee_dui = new string[limit];
            string[] employee_nit = new string[limit];
            double[] employee_salary_per_hour = new double[limit];
            double[] employee_worked_hours = new double[limit];

            for (int i = 0; i < limit; i++) {
                Console.WriteLine("Welcome to Diego's Industry!\n");
                Console.WriteLine($"{i + 1}. Enter the employee name: ");
                employee_name[i] = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Enter the employee DUI: ");
                employee_dui[i] = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Enter the employee NIT: ");
                employee_nit[i] = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Enter the employee salary per hour: ");
                Console.Write("$");
                employee_salary_per_hour[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}. Enter the employee worked hours: ");
                Console.Write("$");
                employee_worked_hours[i] = double.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
