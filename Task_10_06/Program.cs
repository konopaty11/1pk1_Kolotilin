namespace Task_10_06
{
    internal class Program
    {
        /* 
         * Создать Метод ArrayGeneration не возвращающий значения, 
         * принимает целое число n, 
         * выводит на консоль сгенерированный массив размерности n*n.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы: ");
            int n = int.Parse(Console.ReadLine());      // размерность матрицы

            ArrayGeneration(n);
        }

        /// <summary>
        /// Генерирует матрицу случайных чисел размером n * n
        /// </summary>
        /// <param name="n"> размерность матрицы </param>
        static void ArrayGeneration(int n)
        {
            Random rnd = new Random();
            int[,] nums = new int[n, n];    // матрица

            Console.WriteLine("\nСгенерированнный массив:");
            // генерация и вывод
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    nums[i, j] = rnd.Next(10, 100);
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
