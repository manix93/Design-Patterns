using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
	public class NvidiaGraphic : IComputerGraphic
	{
		public NvidiaGraphic()
		{
			Console.WriteLine("Nvidia Graphic");
		}
	}
}
