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
                        Creator.Lesson();
                        break;
                    case "Discipline":
                        Creator.Discipline();
                        break;
                    case "Student":
                        UI.Print(Creator.Student());
                        break;
                    case "Post":
                        Creator.Post();
                        break;
                    case "Employee":
                        Creator.Employee();
                        break;
                    case "ExtraActivity":
                        Creator.ExtraActivity();
                        break;
                    case "Group":
                        Creator.Group();
                        break;
                    case "Theme_LessonType":
                        Creator.Theme_LessonType();
                        break;
                    case "Theme":
                        Creator.Theme();
                        break;
                    case "LessonType":
                        Creator.LessonType();
                        break;
                    case "Pair":
                        Creator.Pair();
                        break;
                    case "Division":
                        Creator.Division();
                        break;
                    case "Organization":
                        Creator.Organization();
                        break;
                    case "Content":
                        Creator.Content();
                        break;
                    case "Shift":
                        Creator.Shift();
                        break;
                    case "Paragraph":
                        Creator.Paragraph();
                        break;
                    case "Equipment":
                        Creator.Equipment();
                        break;
                     case "Auditory":
                        Creator.Auditory();
                        break;
                    default:
                        Console.WriteLine("Такого класса не существует");
                        break;
                }
            }
        }
    }
}




