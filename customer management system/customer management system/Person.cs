// --------------------
// Person.cs
// --------------------

/// <overview>
/// Represents a generic person with fundamental properties.
/// </overview>
namespace customer_management_system
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
