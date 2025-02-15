namespace Task_11_02
{
    internal class Program
    {
        /*  Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке 
         *  и меняет их местами. Проверьте, изменились ли значения переменных вне метода
        */
        static void Main(string[] args)
        {
            Console.Write("Введите число a >> ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("И число b >> ");
            int b = Convert.ToInt32(Console.ReadLine());

            SwapNums(ref a, ref b);
            Console.WriteLine($"\na = {a}; b = {b}");
        }

        /// <summary>
        /// меняет числа местами
        /// </summary>
        /// <param name="a"> первое число </param>
        /// <param name="b"> второе число </param>
        static public void SwapNums(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}