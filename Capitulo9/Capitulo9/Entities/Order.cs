using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitulo9.Entities.Enums;

namespace Capitulo9.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus orderStatus, Client client)
        {
            Moment = DateTime.Now;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void addItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public void removeItem(OrderItem orderItem)
        {
            orderItems.Remove(orderItem);
        }

        public double total()
        {
            double totalValue = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                totalValue += orderItem.subTotal();
            }
            return totalValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Order Sumary \n Order Moment: {Moment} \n Order Status: {OrderStatus} \n " +
                $"Client {Client} \n" +
                $"Order Itens: \n");
            foreach (OrderItem orderItem in orderItems)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine(total().ToString());
            return sb.ToString();
        }
    }
}
