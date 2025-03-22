using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_03
{
    static internal class Factorial
    {
        static int num;

        /// <summary>
        /// если число отрицательное возращается -1
        /// </summary>
        static int Num 
        { 
            get => num; 
            set => num = value < 0 ? -1 : value; 
        }

        /// <summary>
        /// Вычисляет факториал числа
        /// </summary>
        /// <param name="num"> целое число </param>
        /// <returns> факториал числа </returns>
        public static long FactorilOfNum(int num)
        {
            Num = num;
            if (Num == -1) return -1;
            
            long facNum = 1;
            for (int i = 1; i < Num; i++, facNum *= i) { }

            return facNum;
        }
    }
}
