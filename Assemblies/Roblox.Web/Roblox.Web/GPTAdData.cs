namespace Roblox.Web;

public class GPTAdData
{
	public string SlotPath { get; private set; }

	public string AdDimensions { get; private set; }

	public string RandomSlotIdentifyer { get; private set; }

	public GPTAdData(string slotName, string format, string randomSlotIdentifyer)
	{
		SlotPath = slotName;
		AdDimensions = GetAdDimensions(format);
		RandomSlotIdentifyer = randomSlotIdentifyer;
	}

	public static string GetAdDimensions(string format)
	{
		return format switch
		{
			"skyscraper" => "[160, 600]", 
			"rectangle" => "[300, 250]", 
			"narrowskyscraper" => "[120, 600]", 
			"gutter" => "[400, 1180]", 
			"lgutter" => "[400, 1181]", 
			"opapushdown" => "[970, 90]", 
			"filmstrip" => "[300, 600]", 
			_ => "[728, 90]", 
		};
	}
}
