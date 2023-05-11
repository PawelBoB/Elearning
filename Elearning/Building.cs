// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit
namespace Elearning
{
    public class Building
    {
        public string Name { get; }
        public string Address { get; }
        public Employee �ommandant { get; }
        public Organization Organization { get; }

        public Building(string name, string address, Employee commandant, Organization organization)
        {
            Name = name;
            Address = address;
            �ommandant = commandant;
            Organization = organization;
        }
    }
}