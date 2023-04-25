using Elearning;
using System;
using System.Runtime;

namespace Bob
{
    class Program
    {
        static void Main()
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
                    case "Student":
                        Console.WriteLine(CreateStudent());
                        break;
                    case "Post":
                        Console.WriteLine(CreatePost());
                        break;
                    case "Employee":
                        Console.WriteLine(CreateEmployee());
                        break;
                    case "ExtraActivity":
                        Console.WriteLine(CreateExtraActivity());
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
                    case "Paragraph":
                        Console.WriteLine(CreateParagraph());
                        break;
                    case "Equipment":
                        Console.WriteLine(CreateEquipment());
                        break;
                    case "Auditory":
                        Console.WriteLine(CreateAuditory());
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
        static Pair CreatePair()
        {
            return new Pair(GetTimeSpan(), GetTimeSpan(), GetTimeSpan(), GetTimeSpan(), CreateShift());
        }
        
        static TimeSpan GetTimeSpan()
        {
            Console.Write("Введите час: ");
            _ = int.TryParse(Console.ReadLine() ?? "0", out int h);
            Console.Write("Введите минуту: ");
            _ = int.TryParse(Console.ReadLine() ?? "0", out int m);
            Console.Write("Введите секунду: ");
            _ = int.TryParse(Console.ReadLine() ?? "0", out int s);

            return new TimeSpan(h, m, s);
        }
        static Shift CreateShift()
        {
            Console.Write("Название смены: ");
            string a = Console.ReadLine() ?? "";
            return new Shift(a);
        }
        static Student CreateStudent()
        {
            Console.Write("Введите фамилию: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите имя: ");
            string b = Console.ReadLine() ?? "";

            Console.Write("Введите отчество: ");
            string c = Console.ReadLine() ?? "";
            
            static DateTime? GetBirthDay()
                    {
                        try 
                        {
                            Console.Write("Введите день рождения: ");
                            int day = Int32.Parse(Console.ReadLine() ?? "");
                            Console.Write("Введите месяц рождения: ");
                            int month = Int32.Parse(Console.ReadLine() ?? "");
                            Console.Write("Введите год рождения: ");
                            int year = Int32.Parse(Console.ReadLine() ?? "");
                            return new DateTime(year, month, day);
                        }
                        catch 
                        { return (DateTime?)null; } 
                    }
            return new Student(a,b,c, CreateGroup(), GetBirthDay());
        }
        static Group CreateGroup()
        {
            Console.Write("Название группы: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Сокращение группы: ");
            string b = Console.ReadLine() ?? "";

            Console.Write("Численность: ");
            int с = Int32.Parse(Console.ReadLine() ?? "0");

            Console.Write("Код поступления: ");
            int d = Int32.Parse(Console.ReadLine() ?? "0");

            return new Group(a, b, с, d, CreateSpecialization(), CreateEmployee());
        }
        static Specialization CreateSpecialization()
        {
            Console.Write("Название аудитории: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Название абревиатуры: ");
            string b = Console.ReadLine() ?? "";
            return new Specialization(a, b);
        }
        static Discipline CreateDiscipline()
        {
            Console.Write("Название специальтности: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Сокращение: ");
            string b = Console.ReadLine() ?? "";

            return new Discipline(a, b);
        }
        static Employee CreateEmployee()
        {
            Console.Write("Введите фамилию: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите имя: ");
            string b = Console.ReadLine() ?? "";

            Console.Write("Введите отчество: ");
            string с = Console.ReadLine() ?? "";
            return new Employee(a, b, с, CreatePost());
        }
        static ExtraActivity CreateExtraActivity()
        {
            Console.Write("Введите название внеурочной деятельности: ");
            string a = Console.ReadLine() ?? "Нет названия"
            
            return new ExtraActivity(a,CreateEmployee()); 
        }

        static Post CreatePost()
        {
            Console.Write("Введите название должности: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите оклад: ");
            int b = Int32.Parse(Console.ReadLine() ?? "0");

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
            string a = Console.ReadLine() ?? "";

            return new Theme(a);
        }
        static Paragraph CreateParagraph()
        {
            Console.Write("Название параграфа: ");
            string name = Console.ReadLine() ?? "Нет названия";
            return new Paragraph(name, CreateTheme());
        }
        static LessonType CreateLessonType()
        {
            Console.Write("Введите вид занятия: ");
            string a = Console.ReadLine() ?? "";
            return new LessonType(a);
        }
        static Division CreateDivision()
        {
            Console.Write("Название подразделения: ");
            string a = Console.ReadLine() ?? "";

            return new Division(a, CreateEmployee(), CreateOrganization());
        }
        static Organization CreateOrganization()
        {
            Console.Write("Название организации: ");
            string a = Console.ReadLine() ?? "";
            Console.Write("Юридический адрес: ");
            string b = Console.ReadLine() ?? "";
            Console.Write("Фактический адрес: ");
            string c = Console.ReadLine() ?? "";

            return new Organization(a, b, c, CreateEmployee());
        }
        static Content CreateContent()
        {
            Console.Write("Введите название: ");
            string a = Console.ReadLine() ?? "";

            Console.Write("Введите автора: ");
            string b = Console.ReadLine() ?? "";

            return new Content(a, b);

        }

        static Equipment CreateEquipment()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Введите сумму: ");
            _ = int.TryParse(Console.ReadLine(), out int price);
            
            return new Equipment(name, price, CreateDateTime());
        }

        static DateTime CreateDateTime()
        {
            Console.Write("Введите год: ");
            _  = int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Введите месяц: ");
            _ = int.TryParse(Console.ReadLine(), out int month);
            Console.Write("Введите день: ");
            _ = int.TryParse(Console.ReadLine(), out int day);

            return new DateTime(year, month, day);
        }
        
        static Auditory CreateAuditory()
        {
            Console.Write("Введите номер аудитории: ");
            string a = Console.ReadLine() ?? "";
            Console.Write("Введите количество посадочных мест: ");
            _ = int.TryParse(Console.ReadLine(), out int seat);
            Console.Write("Введите количество окон: ");
            _ = int.TryParse(Console.ReadLine(), out int windows);
            List<Equipment> list = new();
            for (int i = 0; i < 3; i++)
            {
                list.Add(CreateEquipment());
            }
           
            return new Auditory(a, CreateEmployee(), seat, windows, list);
        }

    }
}




