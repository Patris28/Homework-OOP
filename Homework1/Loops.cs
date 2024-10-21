using System;

namespace Homework1
{
    public static class Loops
    {
        public static void DemonstrateLoops()
        {
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }

            Console.WriteLine("\nWhile Loop:");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine($"Count: {j}");
                j++;
            }

            Console.WriteLine("\nDo-While Loop:");
            int k = 1;
            do
            {
                Console.WriteLine($"Count: {k}");
                k++;
            } while (k <= 5);
        }
    }
}
