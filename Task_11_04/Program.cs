namespace Task_11_04
{
    internal class Program
    {
        /*
         * Массив параметров (params): Напишите метод, который принимает массив чисел и 
         * возвращает их среднее значение. Используйте ключевое слово params
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

            Console.WriteLine(GetAVG(nums));
            
        }

        /// <summary>
        /// возвращает среднее значение списка чисел
        /// </summary>
        /// <param name="nums"> числа </param>
        /// <returns> среднее арифметическое чисел </returns>
        static double GetAVG(params double[] nums)
        {
            double sum = 0;     // сумма чисел
            int count = 0;      // количество чисел
            foreach (double el in nums)
            {
                if (el == 0) break;
                sum += el;
                count++;
            }

            return sum / count;
        }
    }
}
