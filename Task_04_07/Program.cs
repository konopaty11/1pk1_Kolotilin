namespace Task_04_07
{
    internal class Program
    {
        /*
        В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
        отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
        мальчиков и девочек. При выводе избавиться от отрицательных значений.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] height = new int[30];  

            // количества мальчиков, девочек и их суммарный рост
            int countBoy = 0;       
            double summHeightBoy = 0;
            int countGirl = 0;
            double summHeightGirl = 0;

            for (int i = 0; i < height.Length; i++)
            {
                height[i] = rnd.Next(155, 186) * (rnd.Next(2) * 2 - 1); // рандомно от 155 до 186 и от -155 до -186

                // подсчёт детей и их суммарного роста
                if (height[i] < 0)
                {
                    summHeightBoy += Math.Abs(height[i]);
                    countBoy++;
                }
                else
                {
                    summHeightGirl += height[i];
                    countGirl++;
                }
            }
            Console.WriteLine($"Девочек в классе: {countGirl}, мальчиков: {countBoy}.");
            Console.WriteLine("Ср. рост девочек: {0:g6}, ср. рост мальчиков: {1:g6}", summHeightGirl / countGirl, summHeightBoy / countBoy);
        }
    }
}
