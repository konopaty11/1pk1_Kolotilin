namespace Task_05_09
{
    internal class Program
    {
        /*
        Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
        (это матрица, где все недиагональные элементы меньше нуля)
        Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
        вывести сообщение что данная матрица не является Z-матрицей 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[,] matric = new int[n, n];  // матрица
            bool isZMatric = true;          // переменная проверки Z-матрицы

            // заполение матрицы
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    matric[i, j] = rnd.Next(-10, 11);

                    // проверка на Z-матрицу
                    if (i != j && i != n - j - 1 && matric[i, j] >= 0)
                        isZMatric = false;
                }

            // вывод
            if (isZMatric == false)
                Console.WriteLine("Матрица не является Z-матрицей!");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }

                        Console.Write($"{matric[i, j]} ");
                        Console.BackgroundColor= ConsoleColor.Black;
                        Console.ForegroundColor= ConsoleColor.White;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
