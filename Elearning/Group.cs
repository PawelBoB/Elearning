using Microsoft.VisualBasic;
using System;

public class Group
{
    private string name;
    private string shortName;
    private int number;
    private int yearAdmission;
    private Specialization special;
    private Employee employee;
    public Group(string name, string shortName, int number, int yearAdmission, Specialization special, Employee employee)
    {
        this.name = name;
        this.shortName = shortName;
        this.number = number;
        this.yearAdmission = yearAdmission;
        this.special = special;
        this.employee = employee;
    }
}
