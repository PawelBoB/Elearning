using Elearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    internal class Creator
    {
        public static Lesson Lesson()
        {
            return new Lesson(Discipline(), Employee(), Group(), Pair(), LessonType());
        }
        public static Pair Pair()
        {
            return new Pair(GetTimeSpan(), GetTimeSpan(), GetTimeSpan(), GetTimeSpan(), Shift());
        }

        public static TimeSpan GetTimeSpan()
        {
            Console.Write("Введите час: ");
            _ = int.TryParse(Console.ReadLine() ?? "0", out int h);
            Console.Write("Введите минуту: ");
            _ = int.TryParse(Console.ReadLine() ?? "0", out int m);
            Console.Write("Введите секунду: ");
            _ = int.TryParse(Console.ReadLine() ?? "0", out int s);

            return new TimeSpan(h, m, s);
        }
        public static Shift Shift()
        {
            Console.Write("Название смены: ");
            string a = Console.ReadLine() ?? "";
            return new Shift(a);
        }
        public static Student Student()
        {
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine() ?? "";

            Console.Write("Введите имя: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Введите отчество: ");
            string middleName = Console.ReadLine() ?? "";

            DateOnly dateOnly;
            while(!DateOnly.TryParse(Console.ReadLine(), out dateOnly))
                Console.WriteLine("Введите дату в формате дд.мм.гггг");

            return new Student(lastName, name, middleName, Group(), dateOnly);
        }
        public static Group Group()
        {
            Console.Write("Название группы: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Сокращение группы: ");
            string b = Console.ReadLine() ?? "";

            Console.Write("Численность: ");
            int с = Int32.Parse(Console.ReadLine() ?? "0");

            Console.Write("Код поступления: ");
            int d = Int32.Parse(Console.ReadLine() ?? "0");

            return new Group(a, b, с, d, Specialization(), Employee());
        }
        public static Specialization Specialization()
        {
            Console.Write("Название аудитории: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Название абревиатуры: ");
            string b = Console.ReadLine() ?? "";
            return new Specialization(a, b);
        }
        public static Discipline Discipline()
        {
            Console.Write("Название специальтности: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Сокращение: ");
            string b = Console.ReadLine() ?? "";

            return new Discipline(a, b);
        }
        public static Employee Employee()
        {
            Console.Write("Введите фамилию: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите имя: ");
            string b = Console.ReadLine() ?? "";

            Console.Write("Введите отчество: ");
            string с = Console.ReadLine() ?? "";
            return new Employee(a, b, с, Post());
        }
        public static ExtraActivity ExtraActivity()
        {
            Console.Write("Введите название внеурочной деятельности: ");
            string a = Console.ReadLine() ?? "Нет названия";
            List<Student> students = new();
            for (int i = 0; i < 3; i++)
            {
                students.Add(Student());
            }

            return new ExtraActivity(a, Employee(), students);
        }
        public static Post Post()
        {
            Console.Write("Введите название должности: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите оклад: ");
            int b = Int32.Parse(Console.ReadLine() ?? "0");

            return new Post(a, b, Division());

        }
        public static Theme_LessonType Theme_LessonType()
        {
            UInt16 hours;
            while (!UInt16.TryParse(Console.ReadLine(), out hours))
                Console.WriteLine("Введите количество часов: ");
            return new Theme_LessonType(Theme(), LessonType(), hours);
        }
        public static Theme Theme()
        {
            Console.Write("Название темы: ");
            string a = Console.ReadLine() ?? "";

            return new Theme(a);
        }
        public static Paragraph Paragraph()
        {
            Console.Write("Название параграфа: ");
            string name = Console.ReadLine() ?? "Нет названия";
            return new Paragraph(name, Theme());
        }
        public static LessonType LessonType()
        {
            Console.Write("Введите вид занятия: ");
            string a = Console.ReadLine() ?? "";
            return new LessonType(a);
        }
        public static Division Division()
        {
            Console.Write("Название подразделения: ");
            string a = Console.ReadLine() ?? "";

            return new Division(a, Employee(), Organization());
        }
        public static Organization Organization()
        {
            Console.Write("Название организации: ");
            string a = Console.ReadLine() ?? "";
            Console.Write("Юридический адрес: ");
            string b = Console.ReadLine() ?? "";
            Console.Write("Фактический адрес: ");
            string c = Console.ReadLine() ?? "";

            return new Organization(a, b, c, Employee());
        }
        public static Content Content()
        {
            Console.Write("Введите название: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите автора: ");
            string b = Console.ReadLine() ?? "";

            return new Content(a, b);

        }

        public static Equipment Equipment()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Введите сумму: ");
            _ = int.TryParse(Console.ReadLine(), out int price);

            return new Equipment(name, price, DateTime());
        }

        public static DateTime DateTime()
        {
            Console.Write("Введите год: ");
            _ = int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Введите месяц: ");
            _ = int.TryParse(Console.ReadLine(), out int month);
            Console.Write("Введите день: ");
            _ = int.TryParse(Console.ReadLine(), out int day);

            return new DateTime(year, month, day);
        }
    }
}
