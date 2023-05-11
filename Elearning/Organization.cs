//https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{

    public class Organization
    {
        public string Name { get; }
        public string LegalAddress { get; }
        public string ActualAddress { get; }
        public Employee Supervisor { get; }

        public Organization(string name, string legalAddress, string actualAddress, Employee supervisor)
        {
            Name = name;
            LegalAddress = legalAddress;
            ActualAddress = actualAddress;
            Supervisor = supervisor;
        }
    }
}
