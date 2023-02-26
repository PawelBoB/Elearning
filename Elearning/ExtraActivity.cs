using Microsoft.VisualBasic;
using System;
//https://docs.google.com/document/d/1DUF8Z0-MH7np4AlSFXN5TYCDiut7WdsESiPi-BS8j-4/edit

namespace Elearning
{
    public class ExtraActivity
    {
          private readonly string name;
          public string Name { get { return name; } }

          private readonly Employee director;
          public Employee Director { get { return director; } } 

          private readonly List<Student> students;
          public List<Student> Students { get { return students; } }

          public ExtraActivity(string name, Employee director, List<Student> students)
          {
              this.name = name;
              this.director = director;
              this.students = students;
          }
    }
}