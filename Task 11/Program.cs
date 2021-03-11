using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random randomNumber = new Random();
            int min = 0;
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
