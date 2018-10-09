using System;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
	public class SmartphonesFactory : ISmartphoneFactory
	{
		public ISmartphones OrderSmartphone(SmartphonesEnum smartphone)
		{
			if(smartphone.Equals(SmartphonesEnum.Apple)) {return new AppleSmartphone();}
			else if(smartphone.Equals(SmartphonesEnum.Samsung)) {return new SamsungSmartphone();}
			else if(smartphone.Equals(SmartphonesEnum.Xiaomi)) {return new XiaomiSmartphone();}

			else
			throw new ArgumentException();
		}
	}
}
