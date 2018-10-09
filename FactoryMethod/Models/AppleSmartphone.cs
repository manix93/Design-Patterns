using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
	public class AppleSmartphone : ISmartphones
	{
		public string Manufacturer { get; set; }
		public decimal Costs { get; set; }

		public AppleSmartphone()
		{
			Manufacturer = "iPhone";
			Costs = 1500;
		}
	}
}
