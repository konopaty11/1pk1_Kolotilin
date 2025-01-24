namespace Task_02_04
{
    internal class Program
    {
        /* Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату)
         * произведите расчет является ли пользователь совершеннолетним на текущую дату и выведите 
         * соответствующее сообщение об этом */
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;    // сегоднейшая дата

            Console.WriteLine("Enter your year, mouth and day of birth.");
            int year = Convert.ToInt32(Console.ReadLine());
            int mouth = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());

            int age = today.Year - year;    // разница текущего и введённого года


            // если введённый день и месяц позже текущего - age--
            if (today.Month < mouth)
                age--;
            else if (today.Month == mouth)
                age -= today.Day <= day ? 1 : 0;

            if (age >= 18)
                Console.WriteLine("Congrats! You are of age.");
            else
                Console.WriteLine("Ohhh. I regret, you are kid. Comeback when you are of age!");

        }
    }
}