namespace task_19_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("Текст разделённый на слова:");
            foreach (string word in text.Split())
                Console.WriteLine(word.Trim());

            Console.WriteLine("\nТекст разделённый на предложения:");
            foreach (string sentence in text.Split(new char[3] { '.', '!', '?' }))
                Console.WriteLine(sentence.Trim());
        }
    }
}