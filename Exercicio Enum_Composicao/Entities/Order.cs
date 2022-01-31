using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Enum_Composicao.Entities.Enums;

namespace Exercicio_Enum_Composicao.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; }

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
            sb.Append("Order Summary: ");
            sb.Append("Order Moment: " + Moment);
            sb.Append("Order Status: " + Status);
            sb.Append("Client: " + Client.Name);
            sb.Append("Birth Date: " + Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append("Email: " + Client.Email);
            foreach (OrderItem item in OrderItems) {
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Price);
                sb.Append(", ");
                sb.Append(item.Quantity);
                sb.Append(", ");
                sb.Append(item.SubTotal());                
            }
            sb.Append("Total Price: " + Total());
            return sb.ToString();

        }
    }
}
