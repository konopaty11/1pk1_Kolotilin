namespace Task_19_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resStr = "";

            int i = 1;  // счётчик строк
            while (true)
            {
                Console.Write($"Введите строку {i++} >> ");
                string str = Console.ReadLine();

                if (str == "") break;   // выход из цикла

                resStr = string.Join('-', new string[] { resStr, str });    // формирование результирующей строки
            }

            Console.WriteLine(resStr.Trim('-'));
        }
    }
}
