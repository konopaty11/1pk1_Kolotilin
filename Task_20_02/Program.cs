namespace Task_20_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Results(Enum.Rock, Enum.Paper);
        }

        /// <summary>
        /// вычисляет результат раунда
        /// </summary>
        /// <param name="compChoose"> выбор компьютера </param>
        /// <param name="userChoose"> выбор юзера </param>
        static void Results(Enum compChoose, Enum userChoose)
        {
            /* 
             * преобразование разницы числового представления 
             * выборов компьютера и пользователя
             * из значений -2, 2 в 1, -1 соответственно
            */
            int res = (int)compChoose - (int)userChoose;
            if (res % 2 == 0) res = -(res / 2);

            // итоговое вычисление результата
            if (res == 1) Console.WriteLine("юзер победил");
            else if (res == -1) Console.WriteLine("комп победил");
            else if (res == 0) Console.WriteLine("ничья");
        }
    }
}
