//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Group
    {
        public string Name { get; }
        public string ShortName { get; }
        public UInt16 Size { get; }
        public UInt16 YearAdmission { get;  }
        public Specialization Specialization { get; }
        public Employee Employee { get; } 

        public Group(string name, string shortName, UInt16 size, UInt16 yearAdmission, Specialization special, Employee employee)
        {
            Name = name;
            ShortName = shortName;
            Size = size;
            YearAdmission = yearAdmission;
            Specialization = special;
            Employee = employee;
        }
    }
}