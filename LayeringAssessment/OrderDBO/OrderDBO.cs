using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBO
{
    public class Item
    {
        int itemID;
        string itemName;
        double itemPrice;
        DateTime manufacturingDate;
        int quantity;

        public Item()
        {
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                itemID = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }

            set
            {
                itemPrice = value;
            }
        }

        public DateTime ManufacturingDate
        {
            get
            {
                return manufacturingDate;
            }

            set
            {
                manufacturingDate = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
    public class Order
    {
        int orderID;
        string itemName;
        int quantity;
        double totalPrice;
        string customerName;
        string customerContact;
        string customerEmail;
        public Order()
        {
            //default
        }
        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string CustomerContact
        {
            get
            {
                return customerContact;
            }

            set
            {
                customerContact = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }

            set
            {
                customerEmail = value;
            }
        }

        public Order(string itemName, int quantity, double totalPrice, string customerName, string customerContact, string customerEmail)
        {
            this.ItemName = itemName;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;
            this.CustomerName = customerName;
            this.CustomerContact = customerContact;
            this.CustomerEmail = customerEmail;
        }
    }
}
