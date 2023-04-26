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
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Birthday);
            Print(student.Group);
        }

        private static void Print(Group group)
        {
            throw new NotImplementedException();
        }

        public static void Print(Theme_LessonType themeLessonType)
        {
            Print(themeLessonType.Theme);
            Print(themeLessonType.LessonType);
            Console.WriteLine(themeLessonType.Hours);
        }

        private static void Print(Theme theme)
        {
            throw new NotImplementedException();
        }

        public static void Print(LessonType group)
        {
            throw new NotImplementedException();
        }

        public static void Print(Lesson lesson)
        {
            Console.WriteLine(lesson.Date);
            Print(lesson.Discipline);
            Print(lesson.Employee);
            Print(lesson.Group);
            Print(lesson.Pair);
            Print(lesson.LessonType);
        }

        private static void Print(Pair pair)
        {
            throw new NotImplementedException();
        }

        private static void Print(Employee employee)
        {
            throw new NotImplementedException();
        }

        private static void Print(Discipline discipline)
        {
            throw new NotImplementedException();
        }

        public static void Print(Equipment equipment)
        {
            Console.WriteLine(equipment.Name);
            Console.WriteLine(equipment.Price);
            Console.WriteLine(equipment.RegistrationDate);
        }
    }
}
