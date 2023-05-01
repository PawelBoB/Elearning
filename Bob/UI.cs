using Elearning;

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

        public static void Print(Division division)
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

        public static void Print(Theme theme)
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

        public static void Print(Specialization specialization)
        {
            throw new NotImplementedException();
        }

        public static void Print(LessonType lessonType)
        {
            Console.WriteLine(lessonType.Name);
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

        public static void Print(Pair pair)
        {
            throw new NotImplementedException();
        }

        public static void Print(Employee employee)
        {
            throw new NotImplementedException();
        }

        public static void Print(Discipline discipline)
        {
            throw new NotImplementedException();
        }
        public static void Print(Building building)
        {
            Console.WriteLine(building.Name);
            Console.WriteLine(building.Address);
            Print(building.Employee);
            Print(building.Organization);
        }

        public static void Print(Organization organization)
        {
            throw new NotImplementedException();
        }
    }
}

