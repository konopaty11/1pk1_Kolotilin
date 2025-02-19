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

        public void getInfo()
        {
            Console.WriteLine("Создан экземпляр класса Newapaper");
            Console.WriteLine($"Дата издания: {date} \nзаголовок: {header} \nназвание: {title} \nкол-во страниц: {countOfPages} \nцена: {price}");
        }
    }
}
