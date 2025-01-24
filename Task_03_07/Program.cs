namespace Task_03_07
{
    internal class Program
    {
        /*
        Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
        где 2 g = 9,8 м/с2 – ускорение свободного падения
        */
        static void Main(string[] args)
        {
            double V = 0;   // скорость
            double g = 9.8; // ускорение свободного падения

            Console.WriteLine("Введите время падения тела:");
            double tFinish = Convert.ToDouble(Console.ReadLine());  // время падения тела

            for (double i = 0; i <= tFinish; i += 0.5)
            {
                V = g * i;

                Console.WriteLine("Скорость тела: {0}m/c", V);
            }
        }
    }
}