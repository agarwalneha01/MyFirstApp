using System;

namespace MyFirstApp
{
    public class Iteration
    {
        public static void PrintTable(int num)
        {
            for (int count = 1; count <= 10; count++)
            {
                int result = num * count;
                Console.WriteLine("{0} x {1} = {2}", num, count, result);
            }
            Console.ReadLine();
        }

        public static void PrintTable(int num, int times)
        {
            if (times <= 0)
            {
                Console.WriteLine("Invalid Input...");
                Console.ReadLine();
                return;
            }

            for (int count = 1; count <= times; count++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, count, num * count);
            }
            Console.ReadLine();
        }

        public static void PrintLeapYear(int FromYear, int ToYear)
        {
            if (FromYear <= 0 || ToYear <= 0)
            {
                Console.WriteLine("Invalid Input...");
                Console.ReadLine();
            }
            if (FromYear >= ToYear)
            {
                Console.WriteLine("To Year must be greater than From Year...");
                Console.ReadLine();
            }
            for (int year = FromYear; year <= ToYear; year++)
            {
                bool isLeap = Conditions.IsLeapYear(year);

                if (isLeap == true)
                {
                    Console.WriteLine(year);
                }
            }
            Console.ReadLine();
        }

        public static void PrintSum()
        {
            for (double number = 1; 1 == 1; number++)
            {
                Console.Write("Input First No. ");
                string num = Console.ReadLine();
                if (num == "Exit")
                {
                    Console.WriteLine("Exiting....");
                    Console.ReadLine();
                    return;
                }
                double num1 = double.Parse(num);
                
                Console.Write("Input Second No. ");
                num = Console.ReadLine();
                double num2 = double.Parse(num);

                double sum = num1 + num2;
                Console.WriteLine("Sum = {0}", sum);
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
