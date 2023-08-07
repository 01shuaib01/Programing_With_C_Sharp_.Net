
// Given a number N, the task is to return the count of digits in this numbe

using System;   
namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(n > 0)
            {
                count++;
                n = n / 10;
            }

            Console.WriteLine("total digit is "+count);

        }
    }
}