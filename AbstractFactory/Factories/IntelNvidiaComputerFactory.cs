using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
	public class IntelNvidiaComputerFactory : IComputerFactory
	{
		public IComputerGraphic OrderComputerGraphic()
		{
			var graphic = new NvidiaGraphic();
			return graphic;
		}

		public IComputerProcessor OrderComputerProcessor()
		{
			var processor = new IntelProcessor();
			return processor;
		}
	}
}
