using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Section008Codes.Course.Entities.Enums;

namespace Section008Codes.Course.ExercicioProposto.Entities
{
    public class Order(OrderStatus status, Client client)
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } = status;
        public List<OrderItem> OrderItems { get; set; } = [];
        public Client Client { get; set; } = client;

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem itm in OrderItems)
            {
                total += itm.SubTotal();
            }
            return total;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");

            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total Price: $");
            sb.Append(Total().ToString("F2"));

            return sb.ToString();
        }
    }
}