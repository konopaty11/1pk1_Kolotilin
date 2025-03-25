namespace Task_20_03
{
    internal class Program
    {
        /*
         * Создайте программу для управления статусом заказа в интернет-магазине. Используйте перечислениеOrderStatus со значениями:
            • New (новый)
            • Processing (в обработке)
            • Shipped (отправлен)
            • Delivered (доставлен)
            • Cancelled (отменён)
            Напишите метод, который меняет статус заказа. Если заказ уже доставлен или отменён, запретите изменение статуса. 
            Выводите сообщение при каждом изменении статуса (например,
            "Заказ переведён в статус: Отправлен").
         */
        static void Main(string[] args)
        {
            Order order1 = new Order();
            Console.WriteLine($"Заказ переведён в статус: {order1.Status}");

            order1.ChangeStatus();
            Console.WriteLine($"Заказ переведён в статус: {order1.Status}");

            order1.ChangeStatus();
            Console.WriteLine($"Заказ переведён в статус: {order1.Status}");

            order1.ChangeStatus();
            Console.WriteLine($"Заказ переведён в статус: {order1.Status}");

            order1.ChangeStatus();


            Order order2 = new Order();
            Console.WriteLine($"\nЗаказ переведён в статус: {order2.Status}");

            order2.CancelledOrder();
            Console.WriteLine($"Заказ переведён в статус: {order2.Status}");
            order2.ChangeStatus();
            order2.CancelledOrder();
        }
    }
}
