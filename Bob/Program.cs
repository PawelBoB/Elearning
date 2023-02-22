using System;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Какой класс Вы хотите создать?");
                switch (Console.ReadLine())
                {
                    case "Lesson":
                        Console.WriteLine(CreateLesson());
                        break;
                    case "Discipline":
                        Console.WriteLine(CreateDiscipline());
                        break;
                    case "Post":
                        Console.WriteLine(CreatePost());
                        break;
                    case "Employee":
                        Console.WriteLine(CreateEmployee());
                        break;
                    case "Group":
                        Console.WriteLine(CreateGroup());
                        break;
                    case "Theme_LessonType":
                        Console.WriteLine(CreateTheme_LessonType());
                        break;
                    case "Theme":
                        Console.WriteLine(CreateTheme());
                        break;
                    case "LessonType":
                        Console.WriteLine(CreateLessonType());
                        break;
                    case "Pair":
                        Console.WriteLine(CreatePair());
                        break;
                    case "Division":
                        Console.WriteLine(CreateDivision());
                        break;
                    case "Organization":
                        Console.WriteLine(CreateOrganization());
                        break;
                    case "Content":
                        Console.WriteLine(CreateContent());
                        break;
                    case "Shift":
                        Console.WriteLine(CreateShift());
                        break;
                    default:
                        Console.WriteLine("Такого класса не существует");
                        break;
                }
            }
        }
        static Lesson CreateLesson()
        {
            return new Lesson(CreateDiscipline(), CreateEmployee(), CreateGroup(), CreatePair(), CreateLessonType());
        }
        /*
        static Pair CreatePair()
        {
            Console.Write("Время начала пары: ");
            TimeSpan a = Console.ReadLine();
            Console.Write("время окончания пары: ");
            TimeSpan b = Console.ReadLine();
            Console.Write("время начала перерыва: ");
            TimeSpan c = Console.ReadLine();
            Console.Write("время окончания перерыва: ");
            TimeSpan d = Console.ReadLine();
            return new Pair(a,b,c,d,CreateShift());
        }
        */
        static Pair CreatePair()
        {
            return new Pair(new TimeSpan(), new TimeSpan(), new TimeSpan(), new TimeSpan(), CreateShift());
        }
        static Shift CreateShift()
        {
            Console.Write("Название смены: ");
            string a = Console.ReadLine();
            return new Shift(a);
        }
        static Group CreateGroup()
        {
            Console.Write("Название группы: ");
            string a = Console.ReadLine();

            Console.Write("Сокращение группы: ");
            string b = Console.ReadLine();

            Console.Write("Численность: ");
            int с = Int32.Parse(Console.ReadLine());

            Console.Write("Код поступления: ");
            int d = Int32.Parse(Console.ReadLine());

            return new Group(a, b, с, d, CreateSpecialization(), CreateEmployee());
        }
        static Specialization CreateSpecialization()
        {
            Console.Write("Название аудитории: ");
            string a = Console.ReadLine();

            Console.Write("Название абревиатуры: ");
            string b = Console.ReadLine();
            return new Specialization(a, b);
        }
        static Discipline CreateDiscipline()
        {
            Console.Write("Название специальтности: ");
            string a = Console.ReadLine();

            Console.Write("Сокращение: ");
            string b = Console.ReadLine();

            return new Discipline(a, b);
        }
        static Employee CreateEmployee()
        {
            Console.Write("Введите фамилию: ");
            string a = Console.ReadLine();

            Console.Write("Введите имя: ");
            string b = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string с = Console.ReadLine();
            return new Employee(a, b, с, CreatePost());
        }

        static Post CreatePost()
        {
            Console.Write("Введите название должности: ");
            string a = Console.ReadLine();

            Console.Write("Введите оклад: ");
            int b = Int32.Parse(Console.ReadLine());

            return new Post(a, b, CreateDivision());

        }
        static Theme_LessonType CreateTheme_LessonType()
        {
            Console.Write("Введите количество часов: ");
            return !UInt32.TryParse(Console.ReadLine(), out UInt32 hours) ? CreateTheme_LessonType() : new Theme_LessonType(CreateTheme(), CreateLessonType(), hours);
        }
        static Theme CreateTheme()
        {
            Console.Write("Название темы: ");
            string a = Console.ReadLine();

            return new Theme(a);
        }
        static LessonType CreateLessonType()
        {
            Console.Write("Введите вид занятия: ");
            string a = Console.ReadLine();
            return new LessonType(a);
        }
        static Division CreateDivision()
        {
            Console.Write("Название подразделения: ");
            string a = Console.ReadLine();

            return new Division(a, CreateEmployee(), CreateOrganization());
        }
        static Organization CreateOrganization()
        {
            Console.Write("Название организации: ");
            string a = Console.ReadLine();
            Console.Write("Юридический адрес: ");
            string b = Console.ReadLine();
            Console.Write("Фактический адрес: ");
            string c = Console.ReadLine();

            return new Organization(a, b, c, CreateEmployee());
        }
        static Content CreateContent()
        {
            Console.Write("Введите название: ");
            string a = Console.ReadLine();

            Console.Write("Введите автора: ");
            string b = Console.ReadLine();

            return new Content(a, b, CreateContent());

        }

    }
}




