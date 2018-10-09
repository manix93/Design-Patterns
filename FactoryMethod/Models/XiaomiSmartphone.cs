using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
	public class XiaomiSmartphone : ISmartphones
	{
		public string Manufacturer { get; set; }
		public decimal Costs { get; set; }

		public XiaomiSmartphone()
		{
			Manufacturer = "Xiaomi";
			Costs = 300;
		}
	}
}
