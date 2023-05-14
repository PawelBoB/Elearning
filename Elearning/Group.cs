//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Elearning
{
    public class Group
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public byte Size { get; set; }
        public UInt16 YearAdmission { get; set; }
        public Specialization Specialization { get; set; }
        public Employee Headmaster { get; set; } 

        public Group() : this("Noname", "Noname")
        { }
        public Group(string name, string shortName) : this(name, shortName, 25, 2021, new Specialization(), new Employee())
        { }
        public Group(string name, string shortName, byte size, UInt16 yearAdmission, Specialization specialization, Employee headmaster)
        {
            Name = name;
            ShortName = shortName;
            Size = size;
            YearAdmission = yearAdmission;
            Specialization = specialization;
            Headmaster = headmaster;
        }
        public void Deconstruct(out string group_name, out string group_shortName, out byte group_size, out UInt16 group_yearAdmission, out Specialization group_specialization, out Employee group_headmaster )
        {
            group_name = Name;
            group_shortName = ShortName;
            group_size = Size;
            group_yearAdmission = YearAdmission;
            group_specialization = Specialization;
            group_headmaster = Headmaster;
        }
        public void Print(string name)
        {
            Console.WriteLine($"Полное название: {name}");
        }
        public void Print(string name, string shortname)
        {
            Console.WriteLine($"Полное название: {name}, Сокращенное название: {shortname}");
        }
        public void Print(string name, string shortname, byte size)
        {
            Console.WriteLine($"Полное название: {name}, Сокращенное название: {shortname}, Численность: {size}");
        }
        struct Group_Struct
        {
            public string Name { get; set; }
            public string ShortName { get; set; }
            public byte Size { get; set; }
            public Specialization Specialization { get; set; }
            public Employee Headmaster { get; set; }
            public Group_Struct(Group group)
            {
                Name = group.Name;
                ShortName = group.ShortName;
                Size = group.Size;
                Specialization = group.Specialization;
                Headmaster = group.Headmaster;
            }
        }
    }
}
