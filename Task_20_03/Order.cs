using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    enum StatusOrder
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
    }

    class Order
    {
        public StatusOrder Status { get; private set; } = StatusOrder.New;

        public void ChangeStatus()
        {
            if (Status != StatusOrder.Delivered && Status != StatusOrder.Cancelled) Status++;
            else Console.WriteLine("Заказ уже был доставлен или отменён");
        }

        public void CancelledOrder()
        {
            if (Status != StatusOrder.Cancelled) Status = StatusOrder.Cancelled;
            else Console.WriteLine("Данный заказ уже был отменён");
        }
    }
}
