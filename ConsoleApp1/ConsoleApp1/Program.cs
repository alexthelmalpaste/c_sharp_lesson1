namespace ConsoleApp1
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int orderNumber = 1;
            for (int i = 0; i < 3; i++)
            {
                var order = CreateOrder(orderNumber);
                DisplayOrder(order);
                orderNumber++;
            }
        }

        static (int OrderNumber, string ClientName, string Product, decimal Price, string Address) CreateOrder(int orderNumber)
        {
            Console.WriteLine($"Order Number: {orderNumber}\n");
            Console.WriteLine("Enter Client Name:\n");
            string clientName = Console.ReadLine(); 

            Console.WriteLine("Enter Product Name:\n");
            string product = Console.ReadLine(); 

            Console.WriteLine("Price (EUR):\n");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Address:\n"); 
            string address = Console.ReadLine();

            
            return (orderNumber, clientName, product, price, address);
        }

        static void DisplayOrder((int OrderNumber, string ClientName, string Product, decimal Price, string Address) order)
        {
            Console.WriteLine($"\nOrder No {order.OrderNumber}");
            Console.WriteLine($"Client: {order.ClientName}.");
            Console.WriteLine($"Product: {order.Product}, price {order.Price} EUR.");
            Console.WriteLine($"Address: {order.Address}.\n");
        }
    }
   
}
