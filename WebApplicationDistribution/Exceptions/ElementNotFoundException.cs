namespace WebApplicationDistribution.Exceptions;

public class ElementNotFoundException : Exception
{
	public ElementNotFoundException(string message = "Невозможно найти элемент(ы)")
		: base(message)
	{
	}
}
