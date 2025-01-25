namespace Task_05_03
{
    internal class Program
    {
        /*
         Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
         да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
         элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны. 
        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[,] chars1 = new char[3, 3];        // первый массив
            char[,] chars2 = new char[3, 3];        // второй массив
            char[,] generalChars = new char[3, 3];  // массив повторяющихся значений 
            bool matIsEqual = true;                 // перенная равенства массивов
                
            // заполнение массивов рандомными символами
            for (int i = 0; i < chars1.GetLength(0); i++)
            {
                for (int j = 0; j < chars1.GetLength(1); j++)
                {
                    chars1[i, j] = (char) rnd.Next('a', 'z' + 1);
                    chars2[i, j] = (char) rnd.Next('a', 'z' + 1);

                    /* если символы равны записываем их в общий массив,
                     * если нет переменную равенства массивов делаем равную false */
                    if (chars1[i, j] == chars2[i, j])
                    {
                        generalChars[i, j] = chars1[i, j];
                    }
                    else
                        matIsEqual = false;
                }
            }

            // Вывод 
            if (matIsEqual == true)
                Console.WriteLine("Матрицы равны!");
            else
            {
                Console.WriteLine("Матрица-1 Матрица-2");

                for (int i = 0; i < chars1.GetLength(0); i++)
                {
                    // вывод строки первой матрицы
                    for (int j = 0; j < chars1.GetLength(1); j++)
                    {
                        if (generalChars[i, j] == 0)
                            Console.BackgroundColor = ConsoleColor.Black;
                        else
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"{chars1[i, j]} ");
                    }
                    Console.Write("\t  ");

                    //вывод строки второй матрицы
                    for (int j = 0; j < chars2.GetLength(1); j++)
                    {
                        if (generalChars[i, j] == 0)
                            Console.BackgroundColor = ConsoleColor.Black;
                        else
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"{chars2[i, j]} ");
                    }

                    Console.WriteLine();
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;  
        }
    }
}
