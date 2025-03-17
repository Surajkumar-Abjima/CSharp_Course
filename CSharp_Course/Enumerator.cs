using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course
{
     class Enumerator
    {
        public enum OrderStatus {
            Pending,
            Processing,
            Shipped,
            Delivered
            
        }

        public static void StatusUpdate(OrderStatus status) {
            switch (status) {
                case OrderStatus.Pending:
                    Console.WriteLine("Your Order is pending");
                    break;
                case OrderStatus.Processing:
                    Console.WriteLine("Your order is processed");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("Your order is been shipped");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Your order is delivered");
                    break;
                default:
                    Console.WriteLine("Unknown Status");
                    break;
            }
        }

    }
}
