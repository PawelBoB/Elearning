//https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit?usp=sharing
using Microsoft.VisualBasic;
using System;
public class Organization
{
    private string name;
    private object legalAddress;
    private object actualAddress;
    private Employee employee;
    public Organization(string name, object legalAddress, object actualAddress, Employee employee)
    {
        this.name = name;
        this.legalAddress = legalAddress;
        this.actualAddress = actualAddress;
        this.employee = employee;
    }
}
