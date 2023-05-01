using Elearning;

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
                        UI.Print(Creator.Lesson());
                        break;
                    case "Discipline":
                        Creator.Discipline();
                        break;
                    case "Student":
                        UI.Print(Creator.Student());
                        break;
                    case "Post":
                        UI.Print(Creator.Post());
                        break;
                    case "Employee":
                        Creator.Employee();
                        break;
                    case "ExtraActivity":
                        Creator.ExtraActivity();
                        break;
                    case "Group":
                        UI.Print(Creator.Group());
                        break;
                    case "Theme_LessonType":
                        UI.Print(Creator.Theme_LessonType());
                        break;
                    case "Theme":
                        Creator.Theme();
                        break;
                    case "LessonType":
                        UI.Print(Creator.LessonType());
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
                    case "Building":
                        UI.Print(Creator.Building());
                        break;
                    default:
                        Console.WriteLine("Такого класса не существует");
                        break;
                }
            }
        }
    }
}




