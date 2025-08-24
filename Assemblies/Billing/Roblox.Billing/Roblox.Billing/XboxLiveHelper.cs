using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Roblox.Billing.Properties;

namespace Roblox.Billing;

public class XboxLiveHelper
{
	private const string _InventoryUrl = "https://inventory.xboxlive.com/users/me/inventory/?{0}";

	private const string _ConsumableUrl = "https://inventory.xboxlive.com/users/me/consumables/{0};{1};{1}";

	public static WebRequest CreateXboxLiveServiceRequest(Uri uri, string method, string authorization, string signature, int contentLength = 0)
	{
		WebRequest webRequest = WebRequest.Create(uri);
		webRequest.Timeout = (int)Settings.Default.XboxLiveServiceTimeout.TotalMilliseconds;
		webRequest.Method = method;
		webRequest.ContentType = "application/json";
		webRequest.ContentLength = contentLength;
		webRequest.Headers["Signature"] = signature;
		webRequest.Headers["Authorization"] = authorization;
		webRequest.Headers["X-Xbl-Contract-Version"] = "4";
		return webRequest;
	}

	public static string GenerateConsumableUrl(string xuId, string xboxStoreProductId)
	{
		return string.Format("https://inventory.xboxlive.com/users/me/consumables/{0};{1};{1}", xuId ?? string.Empty, xboxStoreProductId ?? string.Empty);
	}

	/// <summary>
	/// Generates a url to fetch an Xbox Live User's inventory.
	/// </summary>
	/// <remarks>
	/// https://developer.xboxlive.com/en-us/platform/development/documentation/software/Pages/URI_InventoryGET_aug15.aspx
	/// https://forums.xboxlive.com/articles/44790/xbox-one-inventory-improvements-and-xbox-service-a-2.html
	///
	/// Microsoft builds paged inventory responses as what are essentially linked lists.  You request the first page with some
	/// parameters, in this case we have an itemType and some productIds.  If the returned dataset is more than one page of
	/// results, they provide a <paramref name="continuationToken" /> that will fetch the next page of results.  The use of a
	/// <paramref name="continuationToken" /> does not require any other parameters.
	///
	/// </remarks>
	/// <param name="continuationToken">The token for the next page of results.  If null request the first page.</param>
	/// <returns>A valid url to fetch an Xbox Live Inventory.</returns>
	public static string GenerateInventoryUrl(string continuationToken = null)
	{
		if (string.IsNullOrEmpty(continuationToken))
		{
			ICollection<string> productIds = XboxStoreProductFactory.GetAllXboxStoreProductIds();
			return string.Format("https://inventory.xboxlive.com/users/me/inventory/?{0}", string.Format("itemType=GameConsumable&productIds={0}", string.Join(",", productIds)));
		}
		return $"https://inventory.xboxlive.com/users/me/inventory/?{$"continuationToken={continuationToken}"}";
	}

	public static string GenerateJsonBody(string transactionId)
	{
		return JsonConvert.SerializeObject(new
		{
			transactionId = transactionId,
			removeQuantity = 1
		});
	}
}
