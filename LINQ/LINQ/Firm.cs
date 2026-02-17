using System;
using System.Collections.Generic;

namespace FirmApp
{
    public class Firm
    {
        public string Name { get; set; } = string.Empty;
        public string BusinessProfile { get; set; } = string.Empty;
        public string DirectorFullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;


        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
