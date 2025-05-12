using System.ComponentModel;
using System.Diagnostics;

namespace Week_4_Assignment_5._4._1
{
    internal class Program
    {
//        Write a program in C# Sharp to display the individual digits of a given number using recursion.
//        Test Data :
//        Input any number : 1234
//        Expected Output :
//T       he digits in the number 1234 are : 1 2 3 4
       static void DisplayIndividual(int n)
        {
            if(n < 10)
            {
                Console.WriteLine(n + " ");
                return;   
            }
            DisplayIndividual(n / 10);
            Console.WriteLine(((n % 10) + " "));
        }
        static void Main(string[] args)
        {
            int num = 1234;
            Console.Write(num);
        }
    }
}
