// --------------------
// Service.cs
// --------------------

/// <overview>
/// Represents an additional service or amenity a customer might request during booking.
/// Examples include camera rentals, printouts, etc.
/// </overview>
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
