using System;

namespace MyFirstApp
{
    public class Conditions
    {
        public static void SpeedCalculator()
        {
            Console.Write("Please enter distance travelled (Miles): ");
            string distStr = Console.ReadLine();

            double distance = double.Parse(distStr);
            if (distance < 0 || distance > 10000)
            {
                Console.WriteLine("Distance cannot be less than zero. Please press any key to continue...");
                Console.ReadLine();
                return;
            }

            Console.Write("Please enter time taken (Hours): ");
            distStr = Console.ReadLine();

            double hours = double.Parse(distStr);

            double speed = distance / hours;

            Console.WriteLine("Your average speed is {0}", speed);
            Console.ReadLine();
        }


        public static void DegreeToFahrenheit()
        {
            Console.Write("Enter temperature in Degree Celsius: ");
            string temp = Console.ReadLine();

            double celsius = double.Parse(temp);

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("{0} degree celsius euqals to {1} degree fahrenheit.", celsius, fahrenheit);
            Console.ReadLine();

        }

        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static void PrintMyName()
        {
            Console.WriteLine("My Name is Neha");
            Console.ReadLine();
        }

        public static void GreetMe()
        {
            Console.Write("Please enter your name:");
            string str = Console.ReadLine();

            Console.WriteLine("Good morning " + str + ":)");
            Console.ReadLine();
        }

        public static void PrintFamily()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What is your Spouse name: ");
            string spouse = Console.ReadLine();

            Console.Write("What is your kid's name: ");
            string kid = Console.ReadLine();

            Console.Write(name + " and " + spouse + " have a cute kid named " + kid);
            Console.ReadLine();
        }

        public static void PrintSumFixed()
        {
            int a = 10;

            int b = 20;

            int total = a + b;

            Console.WriteLine("Sum = " + total);
            Console.ReadLine();
        }

        public static void PrintSumWithInput()
        {
            Console.Write("Print first number: ");
            string numStr = Console.ReadLine();
            int num1 = int.Parse(numStr);

            Console.Write("Print one more number: ");
            numStr = Console.ReadLine();
            int num2 = int.Parse(numStr);

            int total = num1 + num2;
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + total);
            Console.ReadLine();
        }

        public static void PrintArea()
        {
            Console.Write("Input length: ");
            string meastr = Console.ReadLine();
            double l;
            try
            {
                l = double.Parse(meastr);
            }
            catch
            {
                Console.WriteLine("Invalid input. Exiting PrintArea...");
                return;
            }

            Console.Write("Input width: ");
            meastr = Console.ReadLine();
            double w = double.Parse(meastr);

            double area = l * w;
            Console.WriteLine("Area of Rectangle " + l + " and " + w + " is " + area);
            Console.ReadLine();

        }

        public static void PrintInterest()
        {
            Console.Write("Principal: ");
            string intstr = Console.ReadLine();
            double p = double.Parse(intstr);

            Console.Write("Rate: ");
            intstr = Console.ReadLine();
            double r = double.Parse(intstr);

            if (r < 5 || r > 20)
            {
                Console.Write("Interest rate not allowed ");
                Console.ReadLine();
                return;
            }

            Console.Write("Tenure: ");
            intstr = Console.ReadLine();
            double t = double.Parse(intstr);

            if (t <= 0)
            {
                Console.WriteLine("Tenure cannot be Zero or Negative, Exiting.... ");
                Console.ReadLine();
                return;
            }

            double interest = (p * r * t) / (100 * 12);
            Console.WriteLine("Interest rate = {0}", interest);
            Console.ReadLine();

        }

        public static void CalculatePercentage()
        {
            Console.Write("Sale: ");
            string perstr = Console.ReadLine();
            double s = double.Parse(perstr);

            Console.Write("Rate: ");
            perstr = Console.ReadLine();
            double r = double.Parse(perstr);

            double percentage = s * r / 100;
            Console.WriteLine("Profit = {0}", percentage);
            Console.ReadLine();
        }

        public static void FixedDepositInterestCalculator()
        {

            Console.Write("Enter the Amount (in Rs.): ");
            string fdstr = Console.ReadLine();
            double amount = double.Parse(fdstr);

            Console.Write("Tenure of the Deposit (in years): ");
            fdstr = Console.ReadLine();
            double tenure = double.Parse(fdstr);

            if (tenure > 5 || tenure < 1)
            {
                Console.WriteLine("Invalid tenture... exiting");
                Console.ReadLine();
                return;
            }

            double rate = 0;

            if (tenure == 1)
            {
                rate = 5;
            }
            else if (tenure > 1 && tenure <= 3)
            {
                rate = 6.5;
            }
            else if (tenure > 3 && tenure <= 5)
            {
                rate = 8.5;
            }
            double interest = amount * Math.Pow((1 + rate / 100), tenure) - amount;

            Console.WriteLine("Interest Amount after {0} years is {1}", tenure, interest);
            Console.ReadLine();

            double maturity = amount + interest;
            Console.WriteLine("Amount payable at Maturity is {0}", maturity);
            Console.ReadLine();

        }
    }
}
