// --------------------
// Customer.cs
// --------------------

/// <overview>
/// Represents a customer, inheriting basic properties from Person and adding customer-specific details.
/// </overview>
namespace customer_management_system
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }

        public Customer(int customerId, string name, string phoneNumber) : base(name, phoneNumber)
        {
            CustomerId = customerId;
        }
    }
}
