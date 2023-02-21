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
                    case "Theme_LessonType":
                        Console.WriteLine(CreateTheme_LessonType());
                        break;

                    case "Theme":
                        Console.WriteLine(CreateTheme());
                        break;
                        
                    case "LessonType":
                        Console.WriteLine(CreateLessonType());
                        break;

                    default:
                        Console.WriteLine("Такого класса не существует!");
                        break;
                }
            }
        }

        private static Theme_LessonType CreateTheme_LessonType()
        {
            Console.WriteLine("Введите количество часов: ");
            return !UInt32.TryParse(Console.ReadLine(), out UInt32 hours) ? CreateTheme_LessonType() : new Theme_LessonType(CreateTheme(), CreateLessonType(), hours);
        }

        private static Theme CreateTheme()
        {
            return new Theme();
        }

        private static LessonType CreateLessonType()
        {
            return new LessonType();
        }

    }
}
