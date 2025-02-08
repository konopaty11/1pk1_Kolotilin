namespace Task_10_07
{
    internal class Program
    {
        /*
         * Создайте метод с помощью которого можно сгенерировать 
         * и вернуть символьный двумерный массив(состоящий из символов русского алфавита) 
         * и выведите на консоль данный массив 
         * с помощью другого метода(который принимает данный массив в качестве параметра)
        */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы: ");
            int n = int.Parse(Console.ReadLine());      // размерность матрицы

            char[,] chars = GetArrayGeneretion(n);
            PrintArray(chars);
        }

        /// <summary>
        /// Генерирует матрицу символов русского алфавита n на n
        /// </summary>
        /// <param name="n"> Размерность матрицы </param>
        /// <returns> Сгенерированная матрица </returns>
        static public char[,] GetArrayGeneretion(int n)
        {
            Random rnd = new Random();
            char[,] chars = new char[n, n];     // матрица

            // заполнение матрицы случайными символами русского алфавита
            for (int i = 0; i < n; i++)
                for (int j = 0; j< n; j++)
                    chars[i, j] = (char) rnd.Next('а', 'я' + 1);

            return chars;
        }

        /// <summary>
        /// Выводит на консоль матрицу
        /// </summary>
        /// <param name="chars"> матрица </param>
        static public void PrintArray(char[,] chars)
        {
            Console.WriteLine("\nСимвольная матрица:");
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                    Console.Write($"{chars[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
