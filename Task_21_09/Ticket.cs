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
    class Ticket
    {
        public int Price { get; private set; }          // цена
        public bool IsWithBaggage { get; private set; } // есть ли багаж
        public bool IsBenefit { get; private set; }     // есть ли льгота
        public int Number { get; private set; }         // номер билета

        public static List<Ticket> Tickets = new();

        public Ticket(int price, bool isWithBaggage, bool isBenefit)
        {
            Price = price;
            IsWithBaggage = isWithBaggage;
            IsBenefit = isBenefit;

            Tickets.Add(this);
            Number = Tickets.Count;
        }

        /// <summary>
        /// Вывод в консоль информации о билете
        /// </summary>
        public void PrintTicket()
        {
            string withBaggage = IsWithBaggage == true ? "С багажём" : "Без багажа";
            string benefit = IsBenefit == true ? "Льготный" : "Без льготы";
            Console.WriteLine(
                $"\nЦена: {Price} рублей " +
                $"\nБагаж: {withBaggage}" +
                $"\nЛьгота: {benefit}"
                );
        }
    }
}
