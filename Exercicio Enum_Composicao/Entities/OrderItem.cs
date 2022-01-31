using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Enum_Composicao.Entities {
    class OrderItem {
        public int Quantity { get;  set; }
        public double Price { get;  set; }
        public Product Product { get; private set; }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Quantity * Price;          
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Quantity);
            sb.Append(Price);
            sb.Append(Product.Name);
            return sb.ToString();
        }
    }
}
