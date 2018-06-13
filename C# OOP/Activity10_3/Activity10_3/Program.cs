using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOrderIDs();
        }

        private static void GetOrderIDs()
        {
            var context = new WideWorldImportersEntities();
            var query = from o in context.Orders select o;
            var orders = query.ToList();

            foreach (Order o in orders)
            {
                Console.WriteLine(o.OrderID);
            }
            Console.ReadLine();
        }
    }
}
