using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void printArray(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            int[] createArray(int size)
            {
                int[] array = new int[size];
                for (int i=0; i<size; i++)
                {
                    Console.Write($"Введите {i+1} число: ");
                    array[i] = Convert.ToInt32(Console.ReadLine()); 
                }
                return array;
            }

            int countPositiveNumbers(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0) count ++;
                }
                return count;

            }
            


            Console.Write("Сколько чисел вы собираетесь ввести? ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = createArray(arraySize);
            printArray(numbers);
            Console.WriteLine($"Количество положительных чисел: {countPositiveNumbers(numbers)}");
        }
    }
}