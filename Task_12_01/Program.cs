using Task_12_01.Publications;

namespace Task_12_01
{
    /*
     *  в этом же проекте реализуйте класс Journal (журнал) со следующими данными:
        дата издания, предметно-тематическая направленность журнала, название, количество страниц, ценафункционал класса:
        покупка журнала
        просмотр содержания журнала
        в этом же проекте реализуйте класс Newspaper (газета) со следующими данными:
        дата издания, название газеты, заголовок главной полосы, количество страниц, цена
        функционал класса:
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            Console.WriteLine($"\nПопытка сдать свободную книгу {book1.title}");
            book1.ReturnBook();

            Console.WriteLine($"\nСдача книги: {book2.title}");
            book2.ReturnBook();

            book2.GetBoot();


            //      Класс -- Journal
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tКласс Journal\n");

            Journal journal1 = new Journal() { date = "12.05.2022", theme = "Новостной", title = "The economist", countOfPages = 50, price = 1500 };
            Journal journal2 = new Journal() { date = "02.02.2001", theme = "Юмористический", title = "Анекдоты", countOfPages = 20, price = 300 };

            Console.WriteLine($"Покупка первого журнала");
            journal1.BuyJournal();
            Console.WriteLine($"\nПокупка второго журнала");
            journal2.BuyJournal();

            Console.WriteLine($"\nПовторная покупка первого журнала");
            journal1.BuyJournal();

            Console.WriteLine("\nЧтение второго журнала");
            journal2.ReadingJournal();


            //      Класс -- Newspaper
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tКласс Newspaper\n");

            Newspaper newspaper = new Newspaper() { date = "30.07.2002", header = "Конец света?", title = "Правдивые новости", countOfPages = 10, price = 100 };  

            newspaper.getInfo();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
