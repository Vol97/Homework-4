using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter desired array length: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            Random randomNumber = new Random();
            int[] reverseHalvesArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            if (array.Length % 2 != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    reverseHalvesArray[i] = array[array.Length / 2 + 1 + i];
                }

                int count = 0;

                for (int j = array.Length / 2 + 1; j < array.Length; j++)
                {
                    reverseHalvesArray[j] = array[count++];
                }

                reverseHalvesArray[array.Length / 2] = array[array.Length / 2];
            }
            else
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    reverseHalvesArray[i] = array[array.Length / 2 + i];
                }

                int count = 0;

                for (int j = array.Length / 2; j < array.Length; j++)
                {
                    reverseHalvesArray[j] = array[count++];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{reverseHalvesArray[i]} ");
            }
        }
    }
}
