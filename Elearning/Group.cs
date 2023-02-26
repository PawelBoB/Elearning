//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Group
    {
        private readonly string name;
        private readonly string shortName;
        private readonly int number;
        private readonly int yearAdmission;
        private readonly Specialization special;
        private readonly Employee employee;

        public string Name { get { return name; } }
        public string ShortName { get { return shortName; } }
        public int Number { get { return number; } }
        public int YearAdmission { get { return yearAdmission; } }
        public Specialization Specialization { get { return special; } }
        public Employee Employee { get { return employee; } }

        public Group(string name, string shortName, int number, int yearAdmission, Specialization special, Employee employee)
        {
            this.name = name;
            this.shortName = shortName;
            this.number = number;
            this.yearAdmission = yearAdmission;
            this.special = special;
            this.employee = employee;
        }
    }
}