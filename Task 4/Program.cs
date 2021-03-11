using System;

namespace Task_4
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

            int maxValue = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"\n{maxIndex}");
        }
    }
}
