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
            Console.WriteLine(group.Size);
            Console.WriteLine(group.ShortName);
            Console.WriteLine(group.YearAdmission);
            Print(group.Headmaster);
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
        
        public static void Print(Paragraph paragraph)
        {
            Console.WriteLine(paragraph.Name);
            Print(paragraph.Theme);
        }

        public static void Print(Pair pair)
        {
            Console.WriteLine(pair.BeginningsP);
            Console.WriteLine(pair.BeginningsBreak);
            Console.WriteLine(pair.EndingP);
            Console.WriteLine(pair.EndingBreak);
            Print(pair.Shift);
        }

        public static void Print(Shift shift)
        {
            Console.WriteLine(shift.Name);
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
            Print(building.Commendant);
            Print(building.Organization);
        }

        public static void Print(Organization organization)
        {
            Console.WriteLine(organization.Name);
            Console.WriteLine(organization.LegalAddress);
            Console.WriteLine(organization.ActualAddress);
            Print(organization.Supervisor);
        }

        public static void Print(Content content)
        { 
            Console.WriteLine(content.Name);
            Console.WriteLine(content.Author);
        }
        
        public static void Print(KTP ktp)
        {
            Print(ktp.Paragraph);
            Print(ktp.Lessontype);
            foreach (Content content in ktp.Content)
                Print(content);
            Console.WriteLine(ktp.Number);
            Console.WriteLine(ktp.Hour);
        }
    }
}

