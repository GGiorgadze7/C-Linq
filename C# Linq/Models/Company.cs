using System;
using System.Collections.Generic;
using System.Text;

namespace C__Linq.Models
{
    public class Company
    {
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public BusinessProfile Profile { get; set; }
        public string DirectorName { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>(); 

        public override string ToString()
        {
            return $"saxeli: {Name}, profili: {Profile}, " +
                   $"direqtori: {DirectorName}, tanamshromeblebi: {EmployeeCount}";
        }
    }
}
