namespace Task_21_09
{
    internal class Program
    {
        /*
     * создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
        • поиск билета с максимальной суммой,
        • билета с минимальной суммой,
        • выведите список билетов с багажом
        • выведите список люготных билетов
     */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            

            for (int i = 0; i < 30; i++)
            {
                bool isWithBaggage = rnd.Next(0, 3) == 0;   // 33% шанс на багаж
                bool isBenefit = rnd.Next(0, 10) < 1;       // 10% шанс на льготу
                Ticket ticket = new Ticket(rnd.Next(1, 1001), isWithBaggage, isBenefit);
            }

            // билеты с наименьшей ценой
            List<Ticket> minPriceTickets = Filter.GetMinPrice();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Билеты с наименьшей ценой:");

            for (int i = 0; i < minPriceTickets.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.DarkCyan;
                else Console.ForegroundColor = ConsoleColor.Cyan;

                // вывод информации о книге
                Console.Write($"Билет {minPriceTickets[i].Number}");
                minPriceTickets[i].PrintTicket();
            }

            // билеты с наибольшей ценой
            List<Ticket> maxPriceTickets = Filter.GetMaxPrice();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nБилеты с наибольшей ценой:");

            for (int i = 0; i < maxPriceTickets.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.White;
                else Console.ForegroundColor = ConsoleColor.Gray;

                // вывод информации о книге
                Console.Write($"Билет {maxPriceTickets[i].Number}");
                maxPriceTickets[i].PrintTicket();
            }

            // билеты с багажём
            List<Ticket> ticketsWithBaggege = Filter.GetTicketsWithBaggage();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nБилеты с багажём:");

            for (int i = 0; i < ticketsWithBaggege.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.DarkCyan;
                else Console.ForegroundColor = ConsoleColor.Cyan;

                // вывод информации о книге
                Console.Write($"Билет {ticketsWithBaggege[i].Number}");
                ticketsWithBaggege[i].PrintTicket();
            }

            // льготные билеты
            List<Ticket> ticketsWithBenefit = Filter.GetTicketsIsBenefit();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nБилеты с льготой:");

            for (int i = 0; i < ticketsWithBenefit.Count; i++)
            {
                // смена цвета шрифта
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.White;
                else Console.ForegroundColor = ConsoleColor.Gray;

                // вывод информации о книге
                Console.Write($"Билет {ticketsWithBenefit[i].Number}");
                ticketsWithBenefit[i].PrintTicket();
            }

        }
    }
}
