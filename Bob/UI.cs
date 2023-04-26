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
        public static void Print(Post post)
        {
            Console.WriteLine(post.Name);
            Console.WriteLine(post.Salary);
            Print(post.Division);
        }

        private static void Print(Division division)
        {
            throw new NotImplementedException();
        }

        public static void Print(Student student)

        {
            Console.WriteLine(student.MiddleName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Birthday);
            Print(student.Group);
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

        public static void Print(Group group)
        {
            Console.WriteLine(group.Name);
            Console.WriteLine(group.Number);
            Console.WriteLine(group.ShortName);
            Console.WriteLine(group.YearAdmission);
            Print(group.Employee);
            Print(group.Specialization);
        }

        private static void Print(Specialization specialization)
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
        
        public static void Print(Auditory auditory)
        {
            Console.WriteLine(auditory.Name);
            Console.WriteLine(auditory.Seat);
            Console.WriteLine(auditory.Windows);
            foreach (var equipment in auditory.List)
            {
                Print(equipment);
            }
            Print(auditory.Employee);
        }

        private static void Print(Equipment equipment)
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
<<<<<<< HEAD
        }
    }
}
=======
        }

        public static void Print(Equipment equipment)
        {
            Console.WriteLine(equipment.Name);
            Console.WriteLine(equipment.Price);
            Console.WriteLine(equipment.RegistrationDate);
        }
    }
}
>>>>>>> a621e3961b03eb72ce31d748acae73638ef82554
