using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Pets
{
    internal class Cat
    {
        public string breed;
        public string name;
        public int age;
        private int numberOfCats = 1;   // номер кота
        
        /// <summary>
        /// кот спит и тратит год своей жизни
        /// </summary>
        public void Sleeping()
        {
            Console.WriteLine($"Тише! {name} спит. zZzZzZzZ");
            age++;
            IsDead();
        }

        /// <summary>
        /// реализация шанса на смерть
        /// </summary>
        public void IsDead()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 0)
            {
                Console.WriteLine($"{name} умер! Наверное это потому что он породы: {breed} и ему было {age} лет");
                Console.WriteLine($"Не волнуйтесь я купил вам нового кота >> {name + ++numberOfCats}");
            }
        }

        /// <summary>
        /// вывод мяу
        /// </summary>
        public void Say()
        {
            Console.WriteLine($"{name}: Мяу!");
        }
    }
    
}
