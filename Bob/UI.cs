using Elearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    internal class UI
    {
        public static void Print(Student student)
        {
            Console.WriteLine(student.MiddleName);
            Print(student.Group);
        }

        public static void Print(Group groupI)
        {
            throw new NotImplementedException();
        }
    }
}
