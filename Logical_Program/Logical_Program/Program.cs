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

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.\n");
            Console.WriteLine("1 for Fibonacci Series");
            int Problem = Convert.ToInt32(Console.ReadLine());
            LogicalProgram logicalProgram = new LogicalProgram();

            switch (Problem)
            {
                case 1:
                    logicalProgram.Fibonacci();
                    break;
                default:
                    Console.WriteLine("You Enter Invalid Number");
                    break;
            }

        }
    }
}
             
               