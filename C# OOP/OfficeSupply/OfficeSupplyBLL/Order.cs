using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace OfficeSupplyBLL
{
    public class Order
    {
        ObservableCollection<OrderItem> _orderItemList = new ObservableCollection<OrderItem>();

        public ObservableCollection<OrderItem> OrderItemList { get => _orderItemList; }

        public void AddItem(OrderItem orderItem)
        {
            foreach (var item in OrderItemList)
            {
                if(item.ProdID == orderItem.ProdID)
                {
                    item.Quantity += orderItem.Quantity;

                    return;
                }
            }
            _orderItemList.Add(orderItem);

        }

        public void RemoveItem(string productID)
        {
            foreach (var item in OrderItemList)
            {
                if(item.ProdID == productID)
                {
                    _orderItemList.Remove(item);
                    return;
                }
            }
        }

        public double GetOrderTotal()
        {
            if (OrderItemList.Count == 0)
            {
                return 0;
            }
            else
            {
                double total = 0;
                foreach (var item in OrderItemList) 
                {
                    total += item.SubTotal;
                }

                return total;
            }
        }

        public int PlaceOrder(int employeeID)
        {
            string xmlOrder;
            xmlOrder = "<Order EmployeeID='" + employeeID + "'>";
            foreach (var item in OrderItemList)
            {
                xmlOrder += item.ToString();
            }
            xmlOrder += "</Order>";
            DALOrder dbOrder = new DALOrder();
            return dbOrder.PlaceOrder(xmlOrder);
        }

    }

    


}
