using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
	public class AmdGraphic : IComputerGraphic
	{
		public AmdGraphic()
		{
			Console.WriteLine("AMD Graphic");
		}
	}
}
