using System;
using StringExtensions;

namespace StringTesterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Extension Tester App");
            Console.WriteLine("----------------------------");
            
            // Test with uppercase
            string uppercaseString = "Hello World";
            bool startsWithUpper = uppercaseString.StartsWithUpperCase();
            Console.WriteLine($"String: \"{uppercaseString}\"");
            Console.WriteLine($"Starts with uppercase: {startsWithUpper}");
            
            Console.WriteLine();
            
            // Test with lowercase
            string lowercaseString = "hello world";
            bool startsWithLower = lowercaseString.StartsWithUpperCase();
            Console.WriteLine($"String: \"{lowercaseString}\"");
            Console.WriteLine($"Starts with uppercase: {startsWithLower}");
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}