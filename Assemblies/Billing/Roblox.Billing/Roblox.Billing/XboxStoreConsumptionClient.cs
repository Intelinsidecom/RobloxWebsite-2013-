using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace Roblox.Billing;

public class XboxStoreConsumptionClient : VerificationClientBase, IXboxStoreConsumptionClient
{
	public bool Consume(XboxStoreProofOfPurchase proofOfPurchase)
	{
		try
		{
			Uri uri = new Uri(proofOfPurchase.ConsumableUrl);
			byte[] bytes = Encoding.UTF8.GetBytes(proofOfPurchase.JsonBody);
			WebRequest request = XboxLiveHelper.CreateXboxLiveServiceRequest(uri, "POST", proofOfPurchase.AuthorizationToken, proofOfPurchase.Signature, bytes.Length);
			using Stream requestStream = request.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			using WebResponse webResponse = request.GetResponse();
			using Stream responseStream = webResponse.GetResponseStream();
			using StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
			string jsonResponse = streamReader.ReadToEnd();
			Dictionary<string, object> jsonObject = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(jsonResponse);
			string transactionId = SafeGet(jsonObject, "transactionId");
			string url = SafeGet(jsonObject, "url");
			bool num = string.Equals(proofOfPurchase.TransactionId, transactionId, StringComparison.OrdinalIgnoreCase);
			bool consumableUrlMatches = string.Equals(proofOfPurchase.ConsumableUrl, url, StringComparison.OrdinalIgnoreCase);
			return num && consumableUrlMatches;
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return false;
		}
	}
}
