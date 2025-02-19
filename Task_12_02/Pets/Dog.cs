using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Pets
{
    internal class Dog
    {
        public string breed;
        public string name;
        public int weight;
        private int startWeight = -1;

        /// <summary>
        /// Выводит гав и уменьшает weight
        /// </summary>
        public void Say()
        {
            if (weight - startWeight >= 2)
                Console.WriteLine($"{name} слишком толстый, чтобы гавкать. Собаки породы {breed} не должны столько есть!");
            else
                Console.WriteLine("Гав!!!");
            
        }

        /// <summary>
        /// увеличивает вес
        /// </summary>
        public void Eating()
        {
            // присваиает startWeight начальное значение если оно не определено
            if (startWeight == -1) startWeight = --weight;

            Console.WriteLine($"{name} ест.");
            if (weight - startWeight >= 1) Console.WriteLine("Это было явно лишним.");

            weight++;
        }

        /// <summary>
        /// уменьшает вес
        /// </summary>
        public void Walking()
        {
            // присваиает startWeight начальное значение если оно не определено
            if (startWeight == -1) startWeight = ++weight;

            Console.WriteLine($"{name} на прогулке");
            weight--;
        }
    }
}
