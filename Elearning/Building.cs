namespace Elearning
{
    public class Building
    {
        public string Name { get; }
        public string Address { get; }
        public Employee Employee { get; }
        public Organization Organization { get; }

        public Building(string name, string address, Employee employee, Organization organization)
        {
            Name = name;
            Address = address;
            Employee = employee;
            Organization = organization;
        }
    }
}