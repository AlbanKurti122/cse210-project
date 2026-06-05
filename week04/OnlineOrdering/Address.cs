namespace OnlineOrdering
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            // Kontrollon në mënyrë fleksibile nëse vendi është USA ose United States
            return _country.ToLower() == "usa" || _country.ToLower() == "united states";
        }

        public string GetFullAddressString()
        {
            return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }
}