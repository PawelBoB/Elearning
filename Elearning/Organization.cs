using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Organization
    {
        private readonly string name;
        private readonly object legalAddress;
        private readonly object actualAddress;
        private readonly Employee employee;
        public Organization(string name, object legalAddress, object actualAddress, Employee employee)
        {
            this.name = name;
            this.legalAddress = legalAddress;
            this.actualAddress = actualAddress;
            this.employee = employee;
        }
    }
}