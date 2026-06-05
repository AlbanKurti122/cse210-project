using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================================================
            // POROSIA 1: Klient Brenda USA (Transporti duhet të dalë $5)
            // ============================================================
            Address address1 = new Address("123 Alpine Way", "Provo", "UT", "USA");
            Customer customer1 = new Customer("Jane Doe", address1);
            Order order1 = new Order(customer1);

            Product prod1 = new Product("Wireless Mouse", "M908", 25.50, 1);
            Product prod2 = new Product("Mechanical Keyboard", "K400", 75.00, 1);
            Product prod3 = new Product("AA Batteries (4-pack)", "BATT4", 4.99, 2);

            order1.AddProduct(prod1);
            order1.AddProduct(prod2);
            order1.AddProduct(prod3);

            // Afishimi i Porosisë 1
            Console.WriteLine("==================================================");
            Console.WriteLine("                    ORDER #1                      ");
            Console.WriteLine("==================================================");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Order Price: ${order1.CalculateTotalOrderPrice():F2}");
            Console.WriteLine();

            // ============================================================
            // POROSIA 2: Klient Jashtë USA (Transporti duhet të dalë $35)
            // ============================================================
            Address address2 = new Address("75 Rue de la Paix", "Paris", "Île-de-France", "France");
            Customer customer2 = new Customer("Jean-Pierre", address2);
            Order order2 = new Order(customer2);

            Product prod4 = new Product("USB-C Hub", "HUB07", 34.95, 1);
            Product prod5 = new Product("HDMI Cable 6ft", "HDMI6", 8.25, 3);

            order2.AddProduct(prod4);
            order2.AddProduct(prod5);

            // Afishimi i Porosisë 2
            Console.WriteLine("==================================================");
            Console.WriteLine("                    ORDER #2                      ");
            Console.WriteLine("==================================================");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Order Price: ${order2.CalculateTotalOrderPrice():F2}");
            Console.WriteLine("==================================================");
        }
    }
}