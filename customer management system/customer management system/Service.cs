namespace customer_management_system
{
    public class Service
    {
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public Service(string serviceName, decimal price)
        {
            ServiceName = serviceName;
            Price = price;
        }
    }
}
