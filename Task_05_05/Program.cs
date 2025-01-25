namespace Task_05_05
{
    internal class Program
    {
        /*
        У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
        по следующему правилу:
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк и столбцов в матрице:");
            int n = int.Parse(Console.ReadLine());  // количество строк матрицы
            int m = int.Parse(Console.ReadLine());  // количество столбцов матрицы

            Random rnd = new Random();
            int[,] matric = new int[n, m];  // матрица

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matric[i, j] = rnd.Next(-99, 100);  // заполнение матрицы рандомными числами

                    // проверка условий чисел и задание цвета консоли
                    if (matric[i, j] < 0)
                    {
                        matric[i, j] = Math.Abs(matric[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (matric[i, j] == 0)
                    {
                        matric[i, j] = 1;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{matric[i, j]} ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
        }
    }
}
