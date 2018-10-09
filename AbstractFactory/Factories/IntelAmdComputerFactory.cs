using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
	public class IntelAmdComputerFactory : IComputerFactory
	{
		public IComputerGraphic OrderComputerGraphic()
		{
			var graphic = new AmdGraphic();
			return graphic;
		}

		public IComputerProcessor OrderComputerProcessor()
		{
			var processor = new IntelProcessor();
			return processor;
		}
	}
}
