using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    /*
     * создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
        • поиск билета с максимальной суммой,
        • билета с минимальной суммой,
        • выведите список билетов с багажом
        • выведите список люготных билетов
     */
    static class Filter
    {
        static List<Ticket> tickets = Ticket.Tickets;   // массив экземпляров билета

        /// <summary>
        /// возвращает список билетов с максимальной ценой
        /// </summary>
        /// <returns></returns>
        public static List<Ticket> GetMaxPrice()
        {
            List<Ticket> ticketMaxPrice= new();

            int maxPrice = 0;
            foreach (Ticket tick in tickets)
                if (tick.Price > maxPrice) maxPrice = tick.Price;
            foreach (Ticket tick in tickets)
                if (tick.Price == maxPrice) ticketMaxPrice.Add(tick);

            return ticketMaxPrice;
        }

        /// <summary>
        /// возвращает список билетов с минимальной ценой
        /// </summary>
        /// <returns></returns>
        public static List<Ticket> GetMinPrice()
        {
            List<Ticket> ticketMinPrice = new();

            int maxPrice = 1000;
            foreach (Ticket tick in tickets)
                if (tick.Price < maxPrice) maxPrice = tick.Price;
            foreach (Ticket tick in tickets)
                if (tick.Price == maxPrice) ticketMinPrice.Add(tick);

            return ticketMinPrice;
        }

        /// <summary>
        /// возвращает список билетов с багажём
        /// </summary>
        /// <returns></returns>
        public static List<Ticket> GetTicketsWithBaggage()
        {
            List<Ticket> ticketWithBaggage = new();

            foreach (Ticket tick in tickets)
                if (tick.IsWithBaggage == true) ticketWithBaggage.Add(tick);

            return ticketWithBaggage;
        }

        /// <summary>
        /// возвращает список билетов с багажём
        /// </summary>
        /// <returns></returns>
        public static List<Ticket> GetTicketsIsBenefit()
        {
            List<Ticket> ticketIsBenefit= new();

            foreach (Ticket tick in tickets)
                if (tick.IsBenefit == true) ticketIsBenefit.Add(tick);

            return ticketIsBenefit;
        }
    }
}
