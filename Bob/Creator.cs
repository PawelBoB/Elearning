using Elearning;

namespace Bob
{
    internal class Creator
    {
        public static Lesson Lesson()
        {
            Lesson lesson;
            Console.WriteLine("Введите дату в формате дд.мм.гггг (Если дата не задаётся, введите 0)");
            while (true)
            {
                string input = Console.ReadLine() ?? "";
                if (DateOnly.TryParse(input, out DateOnly dateOnly))
                {
                    lesson = new Lesson(dateOnly, Discipline(), Employee(), Group(), Pair(), LessonType());
                    break;
                }
                else if (input == "0")
                {
                    lesson = new Lesson(Discipline(), Employee(), Group(), Pair(), LessonType());
                    break;
                }
                else Console.WriteLine("Некорректно введена дата!");
            }
            return lesson;
        }
        public static Pair Pair()
        {
            return new Pair(GetTimeSpan(), GetTimeSpan(), GetTimeSpan(), GetTimeSpan(), Shift());
        }

        public static TimeSpan GetTimeSpan()
        {
            int h, m, s;
            while (!int.TryParse(Console.ReadLine(), out h))
                Console.Write("Введите час: ");
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.Write("Введите минуту: ");
            while (!int.TryParse(Console.ReadLine() ?? "0", out s))
                Console.Write("Введите секунду: ");

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
            while (!DateOnly.TryParse(Console.ReadLine(), out dateOnly))
                Console.WriteLine("Введите дату в формате дд.мм.гггг");

            return new Student(lastName, name, middleName, Group(), dateOnly);
        }
        public static Group Group()
        {
            Console.Write("Название группы: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Сокращение группы: ");
            string shortName = Console.ReadLine() ?? "";

            Console.Write("Численность: ");
            byte size = byte.Parse(Console.ReadLine() ?? "0");

            Console.Write("Год поступления: ");
            UInt16 yearAdmission = UInt16.Parse(Console.ReadLine() ?? "0");

            return new Group(name, shortName, size, yearAdmission, Specialization(), Employee());
        }
        public static Building Building()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Введите адрес: ");
            string address = Console.ReadLine() ?? "";
            return new Building(name, address, Employee(), Organization());
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
            decimal b = decimal.Parse(Console.ReadLine() ?? "0");

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
            string Name = Console.ReadLine() ?? "";
            return new LessonType(Name);
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
            _ = decimal.TryParse(Console.ReadLine(), out decimal price);

            DateOnly dateOnly;
            while (!DateOnly.TryParse(Console.ReadLine(), out dateOnly))
                Console.WriteLine("Введите дату в формате дд.мм.гггг");

            return new Equipment(name, price, dateOnly);
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
        
        public static KTP KTP()
        {
            List<Content> contents = new();
            for (int i = 0; i < 3; i++)
            {
                contents.Add(Content());
            }
            Console.Write("Введите номер занятия: ");
            _ = byte.TryParse(Console.ReadLine(), out byte number);
            Console.Write("Введите количество часов: ");
            _ = byte.TryParse(Console.ReadLine(), out byte hour);

            return new KTP(Paragraph(), LessonType(), contents, number, hour);
        }
    }
}
