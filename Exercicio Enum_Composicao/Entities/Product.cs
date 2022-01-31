using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Enum_Composicao.Entities {
    class Product {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}
