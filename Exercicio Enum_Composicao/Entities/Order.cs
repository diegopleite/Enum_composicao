using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Enum_Composicao.Entities.Enums;

namespace Exercicio_Enum_Composicao.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) {
            OrderItems.Add(item);
        }

        public void removeItem(OrderItem item) {
            OrderItems.Remove(item);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in OrderItems) {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();           
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client.Name);
            sb.AppendLine("Birth Date: " + Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Email: " + Client.Email);
            foreach (OrderItem item in OrderItems) {
                sb.AppendLine(item.Product.Name);                
                sb.AppendLine("Price: " + item.Price);                
                sb.AppendLine("Quantity " +item.Quantity);
                sb.AppendLine("Subtotal " + item.SubTotal());                
            }
            sb.Append("Total Price: " + Total());
            return sb.ToString();

        }
    }
}
