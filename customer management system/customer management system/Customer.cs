namespace customer_management_system
{
    internal partial class Program
    {
        class Customer
        {
            public string FirstName { get; }
            public string LastName { get; }
            public string Address { get; }
            public string PhoneNumber { get; }
            public string Allergies { get; }

            public Customer(string firstName, string lastName, string address, string phoneNumber, string allergies)
            {
                FirstName = firstName;
                LastName = lastName;
                Address = address;
                PhoneNumber = phoneNumber;
                Allergies = allergies;
            }
        }
    
    }
}
