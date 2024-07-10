using System;

public class Program
{
    
        static void Main(string[] args)
        {
            Console.WriteLine("The perfect numbers between 1 and 10,000 are:");

            for (int i = 1; i <= 10000; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\nEnter Number to Check if is a perfect number");
             int numbertocheck = Convert.ToInt32(Console.ReadLine());
            if(IsPerfect(numbertocheck))
                {
                Console.WriteLine($"{numbertocheck} is a perfect number");
                }
            else
            {
                Console.WriteLine($"{numbertocheck} is not a perfect number");
            }
        }
    

        static bool IsPerfect(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
