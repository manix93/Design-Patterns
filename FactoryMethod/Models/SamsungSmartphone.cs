using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
	public class SamsungSmartphone : ISmartphones
	{
		public string Manufacturer { get; set; }
		public decimal Costs { get; set; }

		public SamsungSmartphone()
		{
			Manufacturer = "Samsung";
			Costs = 1000;
		}
	}
}
