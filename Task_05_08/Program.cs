namespace Task_05_08
{
    internal class Program
    {
        /*
        Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
        произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
        результирующий массив)
        Вывести результирующий массив 
        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mas1 = new int[10, 10];      // первый массив
            int[,] mas2 = new int[10, 10];      // второй массив
            int[,] resMas = new int[10, 10];    // результирующий массив

            // заполнение массивов
            for (int i = 0; i < mas1.GetLength(0); i++)
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    mas1[i, j] = rnd.Next(1, 10);
                    mas2[i, j] = rnd.Next(1, 10);

                    resMas[i, j] = mas1[i, j] * mas2[i, j];
                }

            // вывод
            for (int i = 0; i < resMas.GetLength(0); i++)
            {
                for (int j = 0; j < resMas.GetLength(1); j++)
                    Console.Write($"{resMas[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
