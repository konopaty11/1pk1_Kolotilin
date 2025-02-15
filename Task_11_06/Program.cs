namespace Task_11_06
{
    internal class Program
    {
        /*
         * Передача массива по значению: Напишите метод, который принимает массив целых чисел 
         * и изменяет его элементы, увеличивая каждый на 1. 
         * Проверьте, изменился ли оригинальный массив вне метода.
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            int[] nums = new int[rnd.Next(10, 21)];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 10);
                Console.Write($"{nums[i]} ");
            }

            Console.WriteLine("\nРезультирующий массив:");
            foreach (int i in nums)
                Console.Write($"{i} ");
        }

        static public void IncrementList(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i]++;
        }
    }
}
