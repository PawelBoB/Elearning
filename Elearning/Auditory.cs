using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
//https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit?usp=drivesdk

namespace Elearning
{
        public class Auditory
        {
            private readonly string name;
            public string Name { get { return name; } }

            private readonly Employee employee;
            public Employee Employee { get { return employee; } }

            private readonly int seat;
            public int Seat { get { return seat; } }
            private readonly int windows;
            public int Windows { get { return windows; } }

            private readonly List<Equipment> list;
            public List<Equipment> List { get { return list; } }

            public Auditory(string name, Employee employee, int seat, int windows, List <Equipment> list)
            {
                this.name = name;
                this.employee = employee;
                this.seat = seat;
                this.windows = windows;
                this.list = list;
            }
        }
}