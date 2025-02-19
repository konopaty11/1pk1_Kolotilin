using Task_12_02.Pets;

namespace Task_12_02
{
    internal class Program
    {
        /*
         * создайте проект с классом Cat и Dog, полностью самостоятельно продумайте данные для объектов класса и их функционал
         */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Здравствуйте! Создайте  питомца.");
                Console.WriteLine("\nВыберите: \n1. Создать кота \n2. Создать собаку");

                int pet = int.Parse(Console.ReadLine());        // номер питомца
                Console.Clear();

                if (pet == 1)
                {
                    Console.Write("Введите имя >> ");
                    string nameCat = Console.ReadLine();

                    Console.Write("Введите породу >> ");
                    string breedCat = Console.ReadLine();

                    Console.Write("Введите возвраст >> ");
                    int ageCat = int.Parse(Console.ReadLine());

                    // создание экземпляра класса Cat
                    Cat cat = new Cat() { breed = breedCat, name = nameCat, age = ageCat };    
                    
                    while (true)
                    {
                        Console.WriteLine("\nВыберите: \n1.Поспать \n2.Мяукнуть \n3.Создать нового питомца");
                        int action = int.Parse(Console.ReadLine());     // номер действия

                        Console.Clear();

                        // вызов действий
                        if (action == 1) cat.Sleeping();
                        else if (action == 2) cat.Say();
                        else if (action == 3) break;

                    }
                }

                if (pet == 2)
                {
                    Console.Write("Введите имя >> ");
                    string nameDog = Console.ReadLine();

                    Console.Write("Введите породу >> ");
                    string breedDog = Console.ReadLine();

                    Console.Write("Введите вес >> ");
                    int weightDog = int.Parse(Console.ReadLine());

                    // создание экземпляра класса Dog
                    Dog dog = new Dog() { breed = breedDog, name = nameDog, weight = weightDog };

                    while (true)
                    {
                        Console.WriteLine("\nВыберите: \n1.Поесть \n2.Гавкнуть \n3.Погулять \n4.Создать нового питомца");
                        int action = int.Parse(Console.ReadLine());     // номер действия

                        Console.Clear();

                        // вызов действий
                        if (action == 1) dog.Eating();
                        else if (action == 2) dog.Say();
                        else if (action == 3) dog.Walking();
                        else if (action == 4) break;

                    }
                }

                
            }
        }
    }
}
