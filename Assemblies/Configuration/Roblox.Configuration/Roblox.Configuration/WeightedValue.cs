namespace Roblox.Configuration;

public class WeightedValue
{
	public string Value { get; set; }

	public int Weight { get; set; }

	public WeightedValue()
	{
	}

	public WeightedValue(string value, int weight)
	{
		Value = value;
		Weight = weight;
	}
}
