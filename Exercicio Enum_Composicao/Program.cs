using Exercicio_Enum_Composicao.Entities;
using Exercicio_Enum_Composicao.Entities.Enums;
using System;

namespace Exercicio_Enum_Composicao {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY):  ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
            Client c = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Order Status(PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            

            Order order = new Order(DateTime.Now, status, c);

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product p = new Product(productName, productPrice);               

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, p);

                order.addItem(orderItem);

                

            }

            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);
        }
    }
}
