namespace AbstractFactory.Interfaces
{
	public interface IComputerFactory
	{
		IComputerGraphic OrderComputerGraphic();
		IComputerProcessor OrderComputerProcessor();
	}
}
