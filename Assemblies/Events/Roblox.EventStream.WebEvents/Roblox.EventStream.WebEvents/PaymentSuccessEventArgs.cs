using System;
using Roblox.EventStream.WebEvents.EventArgs;
using Roblox.EventStream.WebEvents;
using System.Collections.Generic;
namespace Roblox.EventStream.WebEvents {
    public class PaymentSuccessEventArgs : WebEventArgs

{
	/// <summary>
	/// The purchased product ids, including upsell products
	/// </summary>
	public List<int> ProductIds { get; set; }
}


}





