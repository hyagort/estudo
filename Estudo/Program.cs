using Estudo.Entities;
using Estudo.Entities.Enums;
using System;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);
        }
    }
}
