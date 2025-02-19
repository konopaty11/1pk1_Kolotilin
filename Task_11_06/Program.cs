﻿namespace Task_11_06
{
    internal class Program
    {
        /*
         * Передача массива по значению: Напишите метод, который принимает массив целых чисел 
         * и изменяет его элементы, увеличивая каждый на 1. 
         * Проверьте, изменился ли оригинальный массив вне метода.
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            int[] nums = new int[rnd.Next(10, 21)]; // массив
            // заполнение и вывод
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 10);
                Console.Write($"{nums[i]} ");
            }

            IncrementList(nums);

            Console.WriteLine("\nРезультирующий массив:");
            foreach (int i in nums)
                Console.Write($"{i} ");
        }

        /// <summary>
        /// увеличивает елементы массива на 1
        /// </summary>
        /// <param name="nums"> массив </param>
        static public void IncrementList(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i]++;
        }
    }
}
