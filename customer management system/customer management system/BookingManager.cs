using customer_management_system;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class BookingManager
{
    private static readonly string FilePath = "bookings.txt";

    public static void AddBooking(Booking booking)
    {
        string bookingData = $"{booking.BookingId},{booking.Customer.CustomerId},{booking.BookingDate}";
        File.AppendAllText(FilePath, bookingData + Environment.NewLine);

        foreach (var service in booking.Services)
        {
            string serviceData = $"{booking.BookingId},{service.ServiceName},{service.Price}";
            File.AppendAllText(FilePath, serviceData + Environment.NewLine);
        }
    }

    public static List<Booking> LoadBookingsFromFile()
    {
        if (!File.Exists(FilePath)) return new List<Booking>();

        var lines = File.ReadAllLines(FilePath);
        var bookings = new List<Booking>();
        var customers = CustomerManager.LoadCustomersFromFile();

        foreach (var line in lines)
        {
            var parts = line.Split(',');

            if (parts.Length == 3)
            {
                var bookingId = int.Parse(parts[0]);
                var customerId = int.Parse(parts[1]);
                var bookingDate = DateTime.Parse(parts[2]);

                var customer = customers.FirstOrDefault(c => c.CustomerId == customerId) ?? new Customer(customerId, "Unknown", "Unknown");

                var booking = new Booking(bookingId, customer, bookingDate);
                bookings.Add(booking);
            }
            else if (parts.Length == 3)
            {
                var bookingId = int.Parse(parts[0]);
                var serviceName = parts[1];
                var price = decimal.Parse(parts[2]);
                var service = new Service(serviceName, price);
                bookings.First(b => b.BookingId == bookingId).AddService(service);
            }
        }

        return bookings;
    }
}
