namespace Task_11_03
{
    internal class Program
    {
        /*  
         *  Выходной параметр (out): Напишите метод, который принимает строку и 
         *  возвращает через выходной параметр количество гласных и согласных букв в этой строке
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку >> ");
            string str = Console.ReadLine();

            int countVowel;     // количество гласных букв
            int countConsonant; // количество согласных букв

            CountVowAndCons(str, out countVowel, out countConsonant);

            Console.WriteLine($"Количество гласных букв в строке: {countVowel}\nСогласных: {countConsonant}");
        }

        /// <summary>
        /// определяет количество гласных и согласных в строке
        /// </summary>
        /// <param name="str"> строка </param>
        /// <param name="countVowel"> количество гласных </param>
        /// <param name="countConsonant"> количество согласных </param>
        static void CountVowAndCons(string str, out int countVowel, out int countConsonant)
        {
            countVowel = 0;
            countConsonant = 0;

            str = str.ToLower(); // преобразование строки в низший регистр

            char[] vowels = {'a', 'e', 'y', 'u', 'i', 'o'}; // массив гласных букв
            // подсчёт гласных букв в строке
            foreach (char c in str) 
                foreach (char vow in vowels)
                    if (vow == c)
                    {
                        countVowel++;
                        break;
                    }

            countConsonant = str.Length - countVowel; // подсчёт согласных букв
        }
    }
}
