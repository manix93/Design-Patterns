using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
	public class IntelProcessor : IComputerProcessor
	{
		public IntelProcessor()
		{
			Console.WriteLine("Intel Processor");
		}
	}
}
