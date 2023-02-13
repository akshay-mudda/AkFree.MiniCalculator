using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkFree.MiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------     /| |         -------- |       | |             /| --------  ---------  ---------   ");
            Console.WriteLine("|            / | |        |         |       | |            / |    |     |         | |       |   ");
            Console.WriteLine("|           /--| |        |         |       | |           /--|    |     |         | |      /    ");
            Console.WriteLine("|          /   | |        |         |       | |          /   |    |     |         | |------     ");
            Console.WriteLine(" -------- /    |  -------  --------  -------   -------- /    |    |      ---------  |      |    ");
            Console.WriteLine("                                       ");
            Console.WriteLine("Welcome to Console Calculator in C#");
            Console.WriteLine("------------------------------------");

            Console.Write("Please select the number of operands (2 or 3): ");
            int numOperands = int.Parse(Console.ReadLine());

            if (numOperands == 2)
            {
                Console.Write("Please enter your first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Please enter your second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exponentiation");
                Console.WriteLine("6. Logarithm");
                Console.Write("Your option: ");
                int choice = int.Parse(Console.ReadLine());
                double result = 0.0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        result = num1 / num2;
                        break;
                    case 5:
                        result = Math.Pow(num1, num2);
                        break;
                    case 6:
                        result = Math.Log(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        return;
                }

                Console.WriteLine("The result of the operation is: " + result);
                Console.WriteLine("                                      ");
                Console.WriteLine("Thank You");
                Console.WriteLine("                                      ");
                Console.WriteLine("--Created by Akshay");
                Console.WriteLine("                                      ");
                Console.Write("Press any key to close the Calculator console app...");
                Console.ReadKey();
            }
            else if (numOperands == 3)
            {
                Console.Write("Please enter your first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Please enter your second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Please enter your third number: ");
                double num3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exponentiation");
                Console.WriteLine("6. Logarithm");
                Console.Write("Your option: ");
                int choice = int.Parse(Console.ReadLine());
                double result = 0.0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2 + num3;
                        break;
                    case 2:
                        result = num1 - num2 - num3;
                        break;
                    case 3:
                        result = num1 * num2 * num3;
                        break;
                    case 4:
                        result = num1 / num2 / num3;
                        break;
                    case 5:
                        result = Math.Pow(num1, Math.Pow(num2, num3));
                        break;
                    case 6:
                        result = Math.Log(num1, num2) / Math.Log(num3, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        return;
                }

                Console.WriteLine("The result of the operation is: " + result);
                Console.WriteLine("                                      ");
                Console.WriteLine("Thank You");
                Console.WriteLine("                                      ");
                Console.WriteLine("--Created by Akshay");
                Console.WriteLine("                                      ");
                Console.Write("Press any key to close the Calculator console app...");
                Console.ReadKey();

            }
        }
    }
}
