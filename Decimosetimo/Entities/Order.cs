using System;
using System.Text;
using System.Collections.Generic;
using Decimosetimo.Entities.Enums;

namespace Decimosetimo.Entities
{
    class Order
    {
        // Propriedades auto implementadas
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
        // Contrutores

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // Métodos da classe

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double sum = 0.00;
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.Append("Order status: ");
            sb.Append("Client: ");
            sb.Append("Order items: ");

            return sb.ToString();
        }
    }
}
