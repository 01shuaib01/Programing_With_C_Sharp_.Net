
//Problem Statement: Given a number, check whether it is prime or not. A prime number is a natural number that is only divisible by 1 and by itself.

//Examples 1 2 3 5 7 11 13 17 19 

using System;   
namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of n");
            int n = Convert.ToInt32(Console.ReadLine());

            int i;
            for(i = 2; i < n; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine(n + " is not a prime number");
                    break;
                }
            }
            if (n == i)
                Console.WriteLine(n + " is a Prime number");


        }
    }
}