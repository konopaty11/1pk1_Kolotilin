namespace Task_14_03
{
    internal class Program
    {
        /*
         * Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. 
         * Сделайте так, чтобы метод работал только для неотрицательных чисел.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial.FactorilOfNum(5));
            Console.WriteLine(Factorial.FactorilOfNum(-10));
            Console.WriteLine(Factorial.FactorilOfNum(10));
        }
    }
}
