namespace Task_03_04
{
    internal class Program
    {
        /*
         * Пользователь вводит в консоли произвольный текст. После каждого ввода консоль очищается. Когда
         * пользователь вводит слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
         * введенных пользователем.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст.");

            int count = 0;  // счётчик введённых строк
            while (true)
            {
                string text = Console.ReadLine();

                // прекращение считывания с консоли
                if (text == "exit" || text == "")
                    break;

                count++;
                Console.Clear();
            }

            Console.WriteLine($"Вы ввели {count} строк!");
        }
    }
}