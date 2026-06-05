namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }

        public bool LivesInUSA()
        {
            // Thërret metodën e klasës Address për të parë nëse është në USA
            return _address.IsInUSA();
        }

        public string GetFullAddress()
        {
            return _address.GetFullAddressString();
        }
    }
}