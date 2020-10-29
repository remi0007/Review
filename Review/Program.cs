using System;
using System.Collections.Generic;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            var myNumber = 0;

            do
            {
                myNumber++;
                numbers.Add(myNumber);

            } while (myNumber < 25);

            while (myNumber < 50)
            {
                myNumber++;
                numbers.Add(myNumber);
            }
            
            Console.WriteLine("Increase:");

            
            
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 24; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($" {numbers[i]}");
            }
               
        }
    }
}
