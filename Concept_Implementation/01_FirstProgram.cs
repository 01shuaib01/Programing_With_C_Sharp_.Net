using System;   // System is namespace

namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // simply print output in the screen
            Console.WriteLine("welcome to c#");

            Console.WriteLine("Enter value of a ");
            int a = Convert.ToInt32(Console.ReadLine());       // To take input from user. bydefault it takes string value we have convert into specefic datatype according to our choice.
            Console.WriteLine("valus of a is " + a);     

        }
    }
}