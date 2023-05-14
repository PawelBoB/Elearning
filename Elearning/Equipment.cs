// https://docs.google.com/document/d/1ynMOoROmPiCWqPt78fnwQoIJKsoAIgdxhzp1VSjatsE

namespace Elearning
{
	public class Equipment
	{
		public string Name { get; }
		public decimal Price { get; }
		public DateOnly SheetDate { get; }

		public Equipment(string name, decimal price, DateOnly sheetDate)
		{
			Name = name;
			Price = price;
			SheetDate = sheetDate;
		}

		public Equipment(string name, decimal price) : this(name, price, DateOnly.FromDateTime(DateTime.Now)) { }
		public Equipment() : this("������������", 0) { }

		public void Deconstruct(out string name, out decimal price, out DateOnly sheetDate)
		{
			name = Name;
			price = Price;
			sheetDate = SheetDate;
		}

		public void Print() {
			Console.WriteLine($"������������: \n��������: {this.Name}\n����: {this.Price}\n����: {this.SheetDate}");
		}

		public void PrintName()
		{
			Console.WriteLine($"��������: {this.Name}");
		}

        public void PrintPrice()
        {
            Console.WriteLine($"����: {this.Price}");
        }

    }
}
