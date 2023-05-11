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
                        UI.Print(Creator.Pair());
                        break;
                    case "Division":
                        Creator.Division();
                        break;
                    case "Organization":
                        UI.Print(Creator.Organization());
                        break;
                    case "Content":
                        UI.Print(Creator.Content());
                        break;
                    case "Shift":
                        UI.Print(Creator.Shift());
                        break;
                    case "Paragraph":
                        UI.Print(Creator.Paragraph());
                        break;
                    case "Equipment":
                        UI.Print(Creator.Equipment());
                        break;
                    case "Building":
                        UI.Print(Creator.Building());
                        break;
                    case "KTP":
                        UI.Print(Creator.KTP());
                        break;
                    default:
                        Console.WriteLine("Такого класса не существует");
                        break;
                }
            }
        }
    }
}
