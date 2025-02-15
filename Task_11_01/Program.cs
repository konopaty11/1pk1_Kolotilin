namespace Task_11_01
{
    internal class Program
    {
        /*
         * Передача по значению: Напишите метод, который принимает два целых числа и 
         * меняет их местами. Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            Console.Write("Введите число a >> ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("И число b >> ");
            int b = Convert.ToInt32(Console.ReadLine());

            SwapNums(a, b);
            Console.WriteLine($"\na = {a}; b = {b}");
        }

        /// <summary>
        /// меняет числа местами
        /// </summary>
        /// <param name="a"> первое число </param>
        /// <param name="b"> второе число </param>
        static public void SwapNums(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
