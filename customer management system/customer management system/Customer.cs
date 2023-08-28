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
