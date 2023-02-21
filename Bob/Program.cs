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
                    case "ClassA":
                        Console.WriteLine(Lesson().Name);
                        break;
                    case "ClassB":
                        Console.WriteLine(().ClassA.Name);
                        break;
                    default:
                        Console.WriteLine("Такого класса не существует");
                        break;
                }
            }
        }

        static Auditory CreateAuditory()
        {
            return new Auditory();
        }

        static Building CreateBuilding()
        {
            string name;
            string address;
            Employee employee;
            Organization organization;
            return new Building(name, address, employee, organization);
        }

        static Competence CreateCompetence()
        {
            return new Competence();
        }

        static Content CreateContent()
        {
            string name;
            string author;
            return new Content(name, author);
        }

        static Discipline CreateDiscipline()
        {
            string name;
            string abbreviation;
            return new Discipline(name, abbreviation);
        }

        static Division CreateDivision()
        {
            return new Division();
        }

        static Employee CreateEmployee()
        {
            string fam;
            string name;
            string otch;
            Post post;
            return new Employee(fam, name, otch, post);
        }

        static Equipment CreateEquipment()
        {
            string name;
            int price;
            DateTime? registrationDate = null;
            return new Equipment(name, price, registrationDate);
        }

        static ExtraActivity CreateExtraActivity()
        {
            return new ExtraActivity();
        }

        static Group CreateGroup()
        {
            string name;
            string shortName;
            int number;
            int yearAdmission;
            Specialization special;
            Employee employee;
            return new Group(name, shortName, number, yearAdmission, special, employee);
        }

        static KTP CreateKTP()
        {
            return new KTP();
        }

        static KTPHeader CreateKTPHeader()
        {
            return new KTPHeader();
        }

        static Lesson CreateLesson()
        {
            Discipline discipline;
            Employee employee;
            Group group;
            Pair pair;
            LessonType lessonType;
            return new Lesson(discipline, employee, group, pair, lessonType);
        }

        static LessonType CreateLessonType()
        {
            string name;
            return new LessonType(name);
        }

        static Organization CreateOrganization()
        {
            string name;
            object legalAddress;
            object actualAddress;
            Employee employee;
            return new Organization(name, legalAddress, actualAddress, employee);
        }

        static Pair CreatePair()
        {
            TimeSpan beginningsP;
            TimeSpan endingP;
            TimeSpan beginningsBreak;
            TimeSpan endingBreak;
            Shift shift;
            return new Pair(beginningsP, endingP, beginningsBreak, endingBreak, shift);
        }

        static Paragraph CreateParagraph()
        {
            string name;
            Theme theme;
            return new Paragraph(name, theme);
        }

        static Post CreatePost()
        {
            string name;
            int salary;
            Division division;
            return new Post(name, salary, division);
        }

        static Shift CreateShift()
        {
            string name;
            return new Shift(name);
        }

        static Specialization CreateSpecialization()
        {
            string name;
            string abbreviation;
            return new Specialization(name, abbreviation);
        }

        static Student CreateStudent()
        {
            string fam;
            string name;
            string otch;
            Group group;
            DateTime? birthday = null;
            return new Student(fam, name, otch, group, birthday);
        }

        static Theme CreateTheme()
        {
            return new Theme();
        }

        static Theme_LessonType CreateTheme_LessonType()
        {
            Theme theme;
            LessonType lessonType;
            UInt32 hours;
            return new Theme_LessonType(theme, lessonType, hours);
        }
    }
}
