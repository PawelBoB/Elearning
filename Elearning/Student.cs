using Microsoft.VisualBasic;
using System;

public class Student {
    private string fam;
    private string name;
    private string otch;
    private Group group;
    private DateTime? birthday;

    public Student(string fam, string name, string otch, Group group, DateTime? birthday = null) {
        this.fam = fam;
        this.name = name;
        this.otch = otch;
        this.group = group;
        this.birthday = birthday == null ? DateTime.Now : birthday;
    }
}
