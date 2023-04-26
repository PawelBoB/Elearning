//https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{

    public class Organization
    {
        public string Name { get; }
        public object LegalAddress { get; }
        public object ActualAddress { get; }
        public object Employee { get; }

        public Organization(string name, object legalAddress, object actualAddress, object employee)
        {
            Name = name;
            LegalAddress = legalAddress;
            ActualAddress = actualAddress;
            Employee = employee;
        }
    }
}
