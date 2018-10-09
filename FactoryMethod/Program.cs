using System;
using System.Text;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod
{
	class Program
	{
		private static void Main()
		{
			var smartphoneFactory = new SmartphonesFactory() as ISmartphoneFactory;
			var appleSmartphone = smartphoneFactory.OrderSmartphone(SmartphonesEnum.Apple);
			var samsungSmartphone = smartphoneFactory.OrderSmartphone(SmartphonesEnum.Samsung);
			var xiaomiSmartphone = smartphoneFactory.OrderSmartphone(SmartphonesEnum.Xiaomi);

			var sb = new StringBuilder();
			sb.AppendLine("Ordered smartphones:")
				.AppendLine($"{appleSmartphone.Manufacturer} - {appleSmartphone.Costs}")
				.AppendLine($"{samsungSmartphone.Manufacturer} - {samsungSmartphone.Costs}")
				.AppendLine($"{xiaomiSmartphone.Manufacturer} - {xiaomiSmartphone.Costs}");

			Console.WriteLine(sb.ToString());
			Console.ReadKey();
		}
	}
}
