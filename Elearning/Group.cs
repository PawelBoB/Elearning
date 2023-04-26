//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Group
    {
        public string Name { get; }
        public string ShortName { get; }
        public int Number { get; }
        public int YearAdmission { get;  }
        public Specialization Specialization { get; }
        public Employee Employee { get; } 

        public Group(string name, string shortName, int number, int yearAdmission, Specialization special, Employee employee)
        {
            Name = name;
            ShortName = shortName;
            Number = number;
            YearAdmission = yearAdmission;
            Specialization = special;
            Employee = employee;
        }
    }
}