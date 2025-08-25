namespace Roblox.Platform.EventStream.WebEvents.EventArgs;

public class EndpointIncorrectUsageEventArgs : WebEventArgs
{
	/// <summary>
	/// Gets or sets the name of the endpoint. (required)
	/// </summary>
	/// <value>
	/// The name of the endpoint.
	/// </value>
	public string EndpointName { get; set; }

	/// <summary>
	/// Gets or sets the report (optional).
	/// May contain additional information such as arguments values provided by user.
	/// </summary>
	/// <value>
	/// The report.
	/// </value>
	public string Report { get; set; }
}
