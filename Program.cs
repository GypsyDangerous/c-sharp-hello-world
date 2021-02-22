using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
			bool continueRunning = false;
			do {
				Console.WriteLine("Enter the first number: \r");
				int number1 = Convert.ToInt32(Console.ReadLine()); 
				Console.WriteLine("Enter the second number: \r");
				int number2 = Convert.ToInt32(Console.ReadLine()); 
			} while (continueRunning == true);
        }
    }
}
