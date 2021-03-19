using System;

namespace selection_task
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. How old
            
            Console.WriteLine("What is your age");
            string age = Console.ReadLine();
            int Ageint = int.Parse(age); 
            if (Ageint > 17)
            {
                Console.WriteLine("you are of legal adult age");
            }
            else
            {
                Console.WriteLine("you are not of legal adult age");
            }
            Console.WriteLine("press enter key for next questions");
            Console.ReadLine();
            // 2. M/F how old
            
            Console.WriteLine("What is your gender? ");
            string gender = Console.ReadLine();
            Console.WriteLine("What is your age? ");
            string age2 = Console.ReadLine();
            int Ageint2 = int.Parse(age2); 
            if (Ageint2 > 17)
            {
                Console.WriteLine(gender + " is of legal adult age");
            }
            else
            {
                Console.WriteLine(gender + "is not of legal adult age");
            }
            Console.WriteLine("press enter key for next questions");
            Console.ReadLine();
            // 3. Number 10

            Console.WriteLine("enter a number");
            string num1 = Console.ReadLine();
            Console.WriteLine("enter a second number");
            string num2 = Console.ReadLine();
            int num1int = int.Parse(num1);
            int num2int = int.Parse(num2);
            int total = num1int + num2int;
            if (total == 10)
            {
                Console.WriteLine("Sum of numbers equal 10");
            }
            if (total < 10)
            {
                Console.WriteLine("Sum of numbers less than 10");
            }
            if (total > 10)
            {
                Console.WriteLine("Sum of numbers more than 10");
            }
            Console.Read();



        }
    }
}
