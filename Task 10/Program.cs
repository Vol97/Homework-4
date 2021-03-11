using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random randomNumber = new Random();
            int key;
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 1; i < array.Length; i++)
            {
                key = i;
                while (key > 0 && array[key] > array[key - 1])
                {
                    temp = array[key];
                    array[key] = array[key - 1];
                    array[key - 1] = temp;

                    key--;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
