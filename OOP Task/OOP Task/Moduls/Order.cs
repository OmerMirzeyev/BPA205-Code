using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP_Task.Moduls
{
    public class Order
    {
        private string _customer;
        private string _product;
        private int _quantity;
        private double _totalprice;
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity
        { 
            get {  return _quantity; }
            set
            {
                if (value > 0)
                    _quantity = value;
            }
        }
        public double TotalPrice
        {
            get { return Product.Price * Quantity; }

        }
        public Order(Customer customer, Product product, int quantity)
        {
            if (product.Stock >= quantity)
            {
                Customer = customer;
                Product = product;
                Quantity = quantity;
                product.Stock -= quantity;
                Console.WriteLine("Sifaris ugurla yaradildi.");
            }
            else
            {
                Console.WriteLine("Not enough stock");
            }
        }


    }
}
