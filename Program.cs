using System;

namespace Class_Project___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[26];
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine("Element Value = " + i);
            }

            Console.ReadKey();
        }
    }
}
