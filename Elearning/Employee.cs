using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Employee
    {
        private readonly string fam;
        private readonly string name;
        private readonly string otch;
        private readonly Post post;

        public Employee(string fam, string name, string otch, Post post)
        {
            this.fam = fam;
            this.name = name;
            this.otch = otch;
            this.post = post;
        }
#pragma warning disable CS8618 // ����, �� ����������� �������� NULL, ������ ��������� ��������, �������� �� NULL, ��� ������ �� ������������. ��������, ����� �������� ���� ��� ����������� �������� NULL.
        public Employee() //�������� ��� ������������ ������ Group
#pragma warning restore CS8618 // ����, �� ����������� �������� NULL, ������ ��������� ��������, �������� �� NULL, ��� ������ �� ������������. ��������, ����� �������� ���� ��� ����������� �������� NULL.
        { }
    }
}