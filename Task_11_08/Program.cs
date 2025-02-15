namespace Task_11_08
{
    internal class Program
    {
        /*
         * Использование params и out: Напишите метод, который принимает переменное количество чисел 
        и возвращает их сумму и максимальное значение через выходные параметры (out).
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел(не более 100) через enter, заканчивающиеся 0.");

            double[] nums = new double[100];    // массив чисел
            int i = 0;                          // индекс массива чисел

            // ввод последовательности чисел
            double n = double.Parse(Console.ReadLine());
            while (n != 0)
            {
                nums[i++] = n;
                n = double.Parse(Console.ReadLine());
            }

            double sum, maxValue;
            SummAndMaxValue(out sum, out maxValue, nums);

            Console.WriteLine($"Сумма всех чисел: {Math.Round(sum, 2)};\nМаксимальное число: {maxValue}.");
        }

        /// <summary>
        /// Вычисляет сумму и максимальное значение в последовательности чисел
        /// </summary>
        /// <param name="sum"> выходная сумма </param>
        /// <param name="maxValue"> выходное максимальное значение </param>
        /// <param name="nums"> последовательность чисел </param>
        static public void SummAndMaxValue(out double sum, out double maxValue, params double[] nums)
        {
            sum = 0;
            maxValue = nums[0];
            foreach(double i in nums)
            {
                sum += i;
                if (maxValue < i) maxValue = i;
            }
        }
    }
}
