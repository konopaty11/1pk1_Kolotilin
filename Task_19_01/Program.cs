namespace Task_19_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nВведите строку >> ");
                string str = Console.ReadLine();
                Console.Write("Введите строку для поиска >> ");
                string strSearch = Console.ReadLine();

                if (str.Contains(strSearch) && strSearch != "")
                {
                    Console.Write("Введите заменяющию строку >> ");
                    string strReplace = Console.ReadLine();

                    Console.WriteLine(str.Replace(strSearch, strReplace));
                }
                else Console.WriteLine("Данная строка не найдена.");
            }
        }
    }
}
