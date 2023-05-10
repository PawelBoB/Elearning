using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Division
    {
        
        public string Name { get; }
        public Employee Employee { get; }
        public Organization Organization { get; }
        public Division(string name, Employee employee, Organization organization)
        {
            Name = name;
            Employee = employee;
            Organization = organization;
        }
    }
}