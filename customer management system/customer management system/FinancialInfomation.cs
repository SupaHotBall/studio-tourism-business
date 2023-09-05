using System.Collections.Generic;

namespace customer_management_system
{
    public class FinancialInfomation
    {
        private string name;
        private string description;
        private double fees;

        public FinancialInfomation(string name, string description, double fees)
        {
            Name = name;
            Description = description;
            Fees = fees;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Fees { get => fees; set => fees = value; }
    }
}
