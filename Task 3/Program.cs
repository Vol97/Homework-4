using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random randomNumber = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            int minValue = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"\n{minIndex}");
        }
    }
}
