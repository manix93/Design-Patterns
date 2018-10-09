using System;
using System.Collections.Generic;
using AbstractFactory.Enums;
using AbstractFactory.Factories;

namespace AbstractFactory
{
	internal class Program
	{
		private static void Main()
		{
			var computers = new List<ComputerSelectorEnum>
			{
				ComputerSelectorEnum.ProcessorAmdGraphicAmd,
				ComputerSelectorEnum.ProcessorAmdGraphicNvidia,
				ComputerSelectorEnum.ProcessorIntelGraphicAmd,
				ComputerSelectorEnum.ProcessorIntelGraphicNvidia
			};

			foreach (var computer in computers)
			{
				var computerFactory = ComputerFactoryProvider.GetComputer(computer);
				if (computerFactory.Equals(null))
					Console.WriteLine("We cant find this computer.\n");
				else
				{
					Console.WriteLine($"Your computer will include: ");
					computerFactory.OrderComputerProcessor();
					computerFactory.OrderComputerGraphic();
					Console.WriteLine();
				}
			}

			Console.ReadKey();
		}
	}
}
