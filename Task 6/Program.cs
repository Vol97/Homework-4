using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random randomNumber = new Random();
            int[] reverseArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - 1 - i];
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{reverseArray[i]} ");
            }
        }
    }
}
