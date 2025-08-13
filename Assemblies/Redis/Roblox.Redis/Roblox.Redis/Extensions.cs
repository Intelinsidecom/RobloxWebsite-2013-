using StackExchange.Redis;

namespace Roblox.Redis;

public static class Extensions
{
	public static string GetIpPortCombo(this ConnectionMultiplexer multiplexer)
	{
		return ParseIpPortCombo(multiplexer?.Configuration);
	}

	private static string ParseIpPortCombo(string configuration)
	{
		if (string.IsNullOrEmpty(configuration))
		{
			return string.Empty;
		}
		ConfigurationOptions configurationOptions = ConfigurationOptions.Parse(configuration);
		if (configurationOptions.EndPoints.Count > 0)
		{
			return configurationOptions.EndPoints[0].ToString();
		}
		return string.Empty;
	}
}
