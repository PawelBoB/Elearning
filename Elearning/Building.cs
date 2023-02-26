using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Building
    {
        private readonly string name;
        private readonly string address;
        private readonly Employee employee;
        private readonly Organization organization;

        string Name { get { return name; } }
        string Address { get { return address; } }
        Employee Employee { get { return employee; } }
        Organization Organization { get { return organization; } }

        public Building(string name, string address, Employee employee, Organization organization)
        {
            this.name = name;
            this.address = address;
            this.employee = employee;
            this.organization = organization;
        }
    }
}