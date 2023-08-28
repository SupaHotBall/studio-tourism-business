using System.Collections.Generic;
using System;
// --------------------
// Booking.cs
// --------------------

/// <summary>
/// Represents a booking made by a customer. It contains booking details and associated services.
/// </summary>

namespace customer_management_system
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Customer Customer { get; set; }
        public DateTime BookingDate { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();

        public Booking(int bookingId, Customer customer, DateTime bookingDate)
        {
            BookingId = bookingId;
            Customer = customer;
            BookingDate = bookingDate;
        }

        public void AddService(Service service)
        {
            Services.Add(service);
        }
    }
}
