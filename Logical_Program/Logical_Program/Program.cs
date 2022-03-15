using System;

namespace Logical_Program
{
    class LogicalProgram
    {
        public void Fibonacci()
        {
            int num_one = 0;
            int num_two = 1;
            int num_three;

            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                num_three = num_one + num_two;
                Console.WriteLine(num_three + " ");
                num_one = num_two;
                num_two = num_three;
            }

        }

        public void PerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }

            }
            if (sum == number)
            {
                Console.WriteLine("It is Perfect Number ");
            }
            else
            {
                Console.WriteLine("It is not a Perfect Number");
            }
        }

        public void PrimeNumber()
        {
            int Count = 0;
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Count++;
            }
            if (Count == 2)
            {
                Console.WriteLine("It is Prime Number");
            }
            else
            {
                Console.WriteLine("It is Not Prime Number");
            }


        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.\n");
            Console.WriteLine("1 for Fibonacci Series");
            Console.WriteLine("2 for Perfect Number");
            Console.WriteLine("3 for Prime Number");
            int Problem = Convert.ToInt32(Console.ReadLine());
            LogicalProgram logicalProgram = new LogicalProgram();

            switch (Problem)
            {
                case 1:
                    logicalProgram.Fibonacci();
                    break;
                case 2:
                    logicalProgram.PerfectNumber();
                    break;
                case 3:
                    logicalProgram.PrimeNumber();
                    break;
                default:
                    Console.WriteLine("You Enter Invalid Number");
                    break;
            }

        }
    }
}
             
               