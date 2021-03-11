using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random randomNumber = new Random();
            int arrayOddIndexSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(10, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 1; i < array.Length; i += 2)
            {
                arrayOddIndexSum += array[i];
            }

            Console.WriteLine($"\n{arrayOddIndexSum}");
        }
    }
}
