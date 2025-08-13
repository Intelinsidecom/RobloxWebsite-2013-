using System.Collections.Generic;

namespace Roblox.Platform.EventStream.WebEvents;

public class PaymentSuccessEventArgs : WebEventArgs
{
	/// <summary>
	/// The purchased product ids, including upsell products
	/// </summary>
	public List<int> ProductIds { get; set; }
}
