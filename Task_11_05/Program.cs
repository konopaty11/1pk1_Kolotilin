namespace Task_11_05
{
    internal class Program
    {
        /*
         * Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref)
         * и возвращает их сумму и произведение через выходные параметры (out).
        */
        static void Main(string[] args)
        {
            Console.Write("Введите число a >> ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b >> ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum, multy;

            SummAndMulty(ref a, ref b, out sum, out multy);

            Console.WriteLine($"Сумма чисел: {sum}\nПроизведение чисел: {Math.Round(multy, 2)}");
        }

        /// <summary>
        /// вычисление суммы и произведения двух чисел
        /// </summary>
        /// <param name="a"> первое число по ссылке </param>
        /// <param name="b"> второе число по ссылке </param>
        /// <param name="sum"> выходная суммма </param>
        /// <param name="multy"> выходное произведение </param>
        static public void SummAndMulty(ref double a, ref double b, out double sum, out double multy)
        {
            sum = a + b;
            multy = a * b;
        }
    }
}
