using System;

namespace StudentSubmission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read an integer from user input
            int n = int.Parse(Console.ReadLine());

            // Determine if the number is even or odd and print the result
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
