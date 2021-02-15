using System;
using System.Collections.Generic;
using System.Text;

namespace Decimosetimo.Entities
{
    class OrderItem
    {
        //Propriedades auto implementadas

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        // Contrutores

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        // Métodos da classe

        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
