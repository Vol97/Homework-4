using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random randomNumber = new Random();
            int oddNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddNumbers++;
                }
            }

            Console.Write($"\n{oddNumbers}");
        }
    }
}
