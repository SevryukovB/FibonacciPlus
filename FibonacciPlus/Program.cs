using System;
using System.Collections.Generic;

namespace FibonacciPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int startIndex, endIndex;
                Console.WriteLine("Write start position:");
                if (!int.TryParse(Console.ReadLine(), out startIndex) || startIndex <= 0)
                {
                    Console.WriteLine("Make sure you enter an integer field, and it is greater than zero");
                    continue;
                }

                Console.WriteLine("Write end position:");
                if (!int.TryParse(Console.ReadLine(), out endIndex) || endIndex <= startIndex)
                {
                    Console.WriteLine("Make sure you enter an integer field, and it is greater than start position");
                    continue;
                }

                List<int> list = GetPart(startIndex, endIndex);
                if (list != null)
                    list.ForEach(x => Console.Write(x + " "));

                Console.WriteLine();
                Console.ReadKey();
            }
        }
        static List<int> GetPart(int start, int end)
        {
            try
            {
                List<int> arr = new List<int> { 1, 1, 1 };
                for (int i = 3; i < end; i++)
                {
                    int sum = 0;
                    for (int j = i - 3; j < i; j++)
                        sum += arr[j];
                    arr.Add(sum);
                }
                return arr.GetRange(--start, end - start); 
            }
            catch
            {
                return null;
            }
        }
    }
}
