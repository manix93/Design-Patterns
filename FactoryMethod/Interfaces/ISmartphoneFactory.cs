using FactoryMethod.Enums;

namespace FactoryMethod.Interfaces
{
	interface ISmartphoneFactory
	{
		ISmartphones OrderSmartphone(SmartphonesEnum smartphone);
	}
}
