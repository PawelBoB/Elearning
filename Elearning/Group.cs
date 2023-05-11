//https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Group
    {
        public string Name { get; }
        public string ShortName { get; }
        public byte Size { get; }
        public UInt16 YearAdmission { get;  }
        public Specialization Specialization { get; }
        public Employee Headmaster { get; } 

        public Group(string name, string shortName, byte size, UInt16 yearAdmission, Specialization special, Employee headmaster)
        {
            Name = name;
            ShortName = shortName;
            Size = size;
            YearAdmission = yearAdmission;
            Specialization = special;
            Headmaster = headmaster;
        }
        #pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Group() //Заглушка для конструктора класса Student
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        { }
    }
}
