using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalOrderPrice()
        {
            double total = 0;

            foreach (Product product in _products)
            {
                total += product.CalculateTotalCost();
            }

            // Llogarit koston e transportit bazuar tek lokacioni i klientit
            double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
            total += shippingCost;

            return total;
        }

        public string GetPackingLabel()
        {
            string label = "--- PACKING LABEL ---\n";
            foreach (Product product in _products)
            {
                label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "--- SHIPPING LABEL ---\n";
            label += $"{_customer.GetName()}\n{_customer.GetFullAddress()}\n";
            return label;
        }
    }
}