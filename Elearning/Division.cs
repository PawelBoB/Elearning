using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Division
    {
        private readonly string name;
        private readonly Employee employee;
        private readonly Organization organization;
        public Division(string name, Employee employee, Organization organization)
        {
            this.name = name;
            this.employee = employee;
            this.organization = organization;
        }
    }
}