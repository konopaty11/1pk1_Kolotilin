using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
#pragma warning disable

    internal class Book
    {
        public string title; //поле класса - хранит название книги
        public string autor; //поле класса - хранит автора книги
        bool isReading = false; //поле класса - хранит статус книги (выдана ли она читателю)

        //метод класса - печатает в консоль информацию о книге
        public void GetInfo()
        {
            Console.WriteLine($"{autor} : {title}");
        }
        //метод класса - выдает книгу читателю и ставит отметку о выдаче
        public void GetBoot()
        {
            if (isReading)
                Console.WriteLine($"книга {title} в данный момент выдана другому читателю");
            else
            {
                isReading = true;
                Console.WriteLine("книга выдана на неделю");
            }
        }

        /// <summary>
        /// выводит сообщение о сдачи книги
        /// если это невозможно выводит обратное
        /// </summary>
        public void ReturnBook()
        {
            if (isReading)
            {
                isReading = false;
                Console.WriteLine($"Читатель вернул книгу: {title}");
            }
            else Console.WriteLine($"Книга {title} и так свободна");
        }
    }
}
