namespace task_05_07
{
    internal class Program
    {
        /* 
         У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
        числами в диапазоне от 10 до 99 включительно.
        Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
        минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы:");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[,] matric = new int[n, n];
            int[] maxElems = new int[5];
            int minElem = 99;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matric[i, j] = rnd.Next(10, 100);
                    if (matric[i, j] < minElem)
                        minElem = matric[i, j];
                }
            }

            Console.WriteLine($"\n{minElem} - Минимальный элемент матрицы");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    matric[i, j] *= minElem;
                }

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                foreach(int elem in matric)
                {
                    if (maxElems[i] < elem)
                    {
                        if (i >= 1 && elem >= maxElems[i - 1])
                            continue;

                        maxElems[i] = elem;
                    }
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    foreach (int elem in maxElems)
                        if (matric[i, j] == elem)
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                    Console.Write($"{matric[i, j]} ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
        }
    }
}
