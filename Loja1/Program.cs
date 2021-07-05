using System;
using Loja1.Entities.Enums;
using Loja1.Entities;


namespace Loja1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter order Data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);


            for (int i = 0; i < nItems; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qtty = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);
                OrderItem orderitem = new OrderItem(qtty, price, product);
                order.AddItem(orderitem);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(order);
        }
    }
}
