using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Newspaper
    {
        public string date;
        public string header;
        public string title;
        public int countOfPages;
        public int price;
        private bool isTerminate = false;

        /// <summary>
        /// выводит значения полей газеты
        /// </summary>
        public void Reading()
        {
            if (isTerminate) Console.WriteLine($"Неудаётся найти газету: {title}");
            else Console.WriteLine($"Дата издания: {date} \nзаголовок: {header} \nназвание: {title} \nкол-во страниц: {countOfPages} \nцена: {price}");
        }

        /// <summary>
        /// уничтожает газету
        /// </summary>
        public void Terminate()
        {
            if (isTerminate) Console.WriteLine($"Газета: {title} уже уничтожена");
            else
            {
                isTerminate = true;
                Console.WriteLine($"Газета {title} была использована в хозяйственных нуждах");
            }
        }
    }
}
