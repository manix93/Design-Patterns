using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
	public class AmdProcessor : IComputerProcessor
	{
		public AmdProcessor()
		{
			Console.WriteLine("AMD Processor");
		}
	}
}
