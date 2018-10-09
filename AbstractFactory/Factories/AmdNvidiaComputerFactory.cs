using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
	public class AmdNvidiaComputerFactory : IComputerFactory
	{
		public IComputerGraphic OrderComputerGraphic()
		{
			var graphic = new NvidiaGraphic();
			return graphic;
		}

		public IComputerProcessor OrderComputerProcessor()
		{
			var processor = new AmdProcessor();
			return processor;
		}
	}
}
