using AbstractFactory.Enums;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
	public class ComputerFactoryProvider
	{
		public static IComputerFactory GetComputer(ComputerSelectorEnum selector)
		{
			if(selector == ComputerSelectorEnum.ProcessorAmdGraphicAmd) { return new AmdAmdComputerFactory(); }
			else if(selector == ComputerSelectorEnum.ProcessorAmdGraphicNvidia) { return new AmdNvidiaComputerFactory(); }
			else if(selector == ComputerSelectorEnum.ProcessorIntelGraphicAmd) { return new IntelAmdComputerFactory(); }
			else if (selector == ComputerSelectorEnum.ProcessorIntelGraphicNvidia) { return new IntelNvidiaComputerFactory(); }

			else return null;
		}
	}
}
