using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Journal
    {
        public string date;
        public string theme;
        public string title;
        public int countOfPages;
        public int price;
        private bool isBuy = false; // куплен ли журнал

        /// <summary>
        /// выводит сообщение о приобртении журнала 
        /// если это возможно
        /// </summary>
        public void BuyJournal()
        {
            if (isBuy) Console.WriteLine($"Журнал: {title} уже приобретён");
            else
            {
                isBuy = true;
                Console.WriteLine($"Вы приобрели журнал: {title}, выпущенный: {date} за {price}");
            }
        }

        /// <summary>
        /// выводит информацию о прочитанном журнале
        /// </summary>
        public void ReadingJournal()
        {
            Console.WriteLine($"Вы прочитали журнал:{title} \nВыпуска: {date} \nТематика:{theme} \nОбъёмом {countOfPages} страниц");
        }
    }
}
