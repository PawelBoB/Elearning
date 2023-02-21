using Microsoft.VisualBasic;
using System;

public class Building
{
    private string name;
    private string address;
    private Employee employee;
    private Organization organization;
    public Building(string name, string address, Employee employee, Organization organization)
    {
        this.name = name;
        this.address = address;
        this.employee = employee;
        this.organization =organization;
    }
}
