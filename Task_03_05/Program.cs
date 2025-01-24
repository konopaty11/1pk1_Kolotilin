namespace Task_03_05
{
    internal class Program
    {
        /*
          Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
          Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
          время работы программы
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг и диапозон(от и до) в градусах Цельсия для таблицы изменения температуры.");
            double step = Convert.ToDouble(Console.ReadLine());     // шаг
            double start = Convert.ToDouble(Console.ReadLine());    // от
            double finish = Convert.ToDouble(Console.ReadLine());   // до

            for (double i = start; i <= finish; i += step)
            {
                double tempF = i * 1.8 + 32; // темп. в Фарингейтах

                Console.WriteLine($"{i}°C = {tempF}°F");
            }
        }
    }
}