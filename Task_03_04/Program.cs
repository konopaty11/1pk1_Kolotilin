namespace Task_03_04
{
    internal class Program
    {
        /*
         * Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
         * пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
         * введенных пользователем.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст.");

            int count = 0;  // счётчик введённых строк
            while (true)
            {
                count++;
                Console.Clear();

                string text = Console.ReadLine();

                // прекращение считывания с консоли
                if (text == "exit" || text == "")
                {
                    count -= text == "" ? 1 : 0;    // если текст пустой не считать его за введённую строку

                    Console.WriteLine($"Вы ввели {count} строк текста!");
                    break;
                }
            }
        }
    }
}