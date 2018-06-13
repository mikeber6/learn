using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace OfficeSupplyBLL
{
    public class OrderItem : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

        }
        #endregion

        string _ProdID;
        int _Quantity;
        double _UnitPrice;
        double _SubTotal;

        public string ProdID { get => _ProdID; set => _ProdID = value; }
        public int Quantity
        { 
            get 
            {
                return _Quantity; 
            }
            set
            {
                _Quantity = value;
                Notify("Quantity");
            }

        }
        public double UnitPrice { get => _UnitPrice; set => _UnitPrice = value; }
        public double SubTotal { get => _SubTotal; }

        public OrderItem(string productID, double unitPrice, int quantity)
        {
            ProdID = productID;
            UnitPrice = unitPrice;
            Quantity = quantity;
            _SubTotal = UnitPrice * Quantity;
        }

        public override string ToString()
        {
            string xml = "<OrderItem";
            xml += " ProductID='" + ProdID + "'";
            xml += " Quantity='" + Quantity + "'";
            xml += " />";
            return xml;

            //return base.ToString();   //auto-generated
        }


    }
}
