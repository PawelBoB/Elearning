// https://docs.google.com/document/d/1ynMOoROmPiCWqPt78fnwQoIJKsoAIgdxhzp1VSjatsE

namespace Elearning
{
    public class Equipment
    {
        public string Name { get; }
        public UInt16 Price { get; }
        public DateOnly RegistrationDate { get; }

        public Equipment(string name, UInt16 price, DateOnly? registrationDate = null)
        {
            Name = name;
            Price = price;
            RegistrationDate = registrationDate ?? DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
