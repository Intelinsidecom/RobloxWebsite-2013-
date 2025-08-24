namespace Roblox.ContentFilterApi.Client;

public class Evaluation
{
	public byte CategoryId { get; set; }
	public byte CategoryID { get; set; } // Alias for compatibility
	public string Text { get; set; }
	public double Probability { get; set; }
	public bool IsBad { get; set; }
	public string CategoryName { get; set; }
}
