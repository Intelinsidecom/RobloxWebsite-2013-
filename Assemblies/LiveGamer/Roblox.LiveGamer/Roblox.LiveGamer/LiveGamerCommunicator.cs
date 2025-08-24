using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml;
using Newtonsoft.Json;
using Roblox.Billing;
using Roblox.LiveGamer.Properties;

namespace Roblox.LiveGamer;

public class LiveGamerCommunicator : ILiveGamerCommunicator
{
	private const string ItemKeyPrefix = "RobloxItem_";

	private string CallbackSecretKey => Settings.Default.LiveGamerCallbackSecret;

	private string AppFamilyId => Settings.Default.LiveGamerAppFamilyId;

	private string SecretKey => Settings.Default.LiveGamerSecretKey;

	private string BaseUrl => Settings.Default.LiveGamerBaseUrl;

	private static string GetSha256(string content)
	{
		SHA256Managed sHA256Managed = new SHA256Managed();
		return Enumerable.Aggregate(seed: string.Empty, source: sHA256Managed.ComputeHash(Encoding.UTF8.GetBytes(content), 0, Encoding.UTF8.GetByteCount(content)), func: (string current, byte bit) => current + bit.ToString("x2"));
	}

	private static string GetHmacsha256(string content, string key)
	{
		HMACSHA256 hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(key));
		byte[] contentBytes = Encoding.UTF8.GetBytes(content);
		hmacsha256.ComputeHash(contentBytes);
		string sbinary = "";
		for (int i = 0; i < hmacsha256.Hash.Length; i++)
		{
			sbinary += hmacsha256.Hash[i].ToString("X2");
		}
		return sbinary;
	}

	public string GetPaymentInitUrl(LiveGamerInitTransactionResult transactionResult)
	{
		LiveGamerLineItem item = transactionResult.LineItems.First();
		StringBuilder sb = new StringBuilder();
		JsonTextWriter jsonTextWriter = new JsonTextWriter(new StringWriter(sb));
		jsonTextWriter.Formatting = Newtonsoft.Json.Formatting.None;
		jsonTextWriter.WriteStartObject();
		jsonTextWriter.WritePropertyName("auth.appFamilyId");
		jsonTextWriter.WriteValue(AppFamilyId);
		jsonTextWriter.WritePropertyName("createUser");
		jsonTextWriter.WriteStartObject();
		jsonTextWriter.WritePropertyName("externalKey");
		jsonTextWriter.WriteValue(transactionResult.UserId.ToString());
		jsonTextWriter.WritePropertyName("userEmail");
		jsonTextWriter.WriteValue(transactionResult.UserEmail);
		jsonTextWriter.WriteEndObject();
		jsonTextWriter.WritePropertyName("user.country");
		jsonTextWriter.WriteValue(transactionResult.CountryCode.ToUpper());
		jsonTextWriter.WritePropertyName("lockCountry");
		jsonTextWriter.WriteValue(value: true);
		jsonTextWriter.WritePropertyName("flowType");
		jsonTextWriter.WriteValue("ITEM-DYNAMIC");
		jsonTextWriter.WritePropertyName("dynamicItem");
		jsonTextWriter.WriteStartObject();
		jsonTextWriter.WritePropertyName("externalKey");
		jsonTextWriter.WriteValue("RobloxItem_" + item.Id);
		jsonTextWriter.WritePropertyName("description");
		jsonTextWriter.WriteValue(item.Description);
		jsonTextWriter.WritePropertyName("currency");
		jsonTextWriter.WriteValue(item.CurrencyCode.ToUpper());
		jsonTextWriter.WritePropertyName("price");
		jsonTextWriter.WriteValue(item.Price.ToString());
		jsonTextWriter.WritePropertyName("smallImage");
		jsonTextWriter.WriteValue(item.Image);
		jsonTextWriter.WriteEndObject();
		jsonTextWriter.WritePropertyName("poMemo");
		jsonTextWriter.WriteValue(transactionResult.LiveGamerTransactionId.ToString());
		jsonTextWriter.WriteEndObject();
		return $"{BaseUrl}?payload={HttpUtility.UrlEncode(sb.ToString())}&signature={GetSha256(SecretKey + sb)}";
	}

	public bool VerifySignature(string callbackXmlContent, string signature)
	{
		if (string.IsNullOrEmpty(callbackXmlContent))
		{
			throw new ArgumentException("Is null or empty", "callbackXmlContent");
		}
		if (string.IsNullOrEmpty(signature))
		{
			throw new ArgumentException("Is null or empty", "signature");
		}
		return string.Compare(GetHmacsha256(callbackXmlContent, CallbackSecretKey), signature, StringComparison.OrdinalIgnoreCase) == 0;
	}

	public LiveGamerTransactionInfo DeserializeCallbackContent(string callbackXmlContent, string signature)
	{
		if (string.IsNullOrEmpty(callbackXmlContent))
		{
			throw new ArgumentException("Is null or empty", "callbackXmlContent");
		}
		LiveGamerTransactionInfo liveGamerTransactionInfo = new LiveGamerTransactionInfo
		{
			CallbackXmlContent = callbackXmlContent,
			Signature = signature
		};
		List<LiveGamerLineItem> lineItems = new List<LiveGamerLineItem>();
		using (XmlReader reader = XmlReader.Create(new StringReader(callbackXmlContent)))
		{
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
					case "purchaseSummary":
					{
						LiveGamerPaymentStatusType paymentStatus = LiveGamerPaymentStatusType.GetByValue(reader.GetAttribute("state"));
						liveGamerTransactionInfo.PaymentStatusId = paymentStatus.ID;
						liveGamerTransactionInfo.InternalPaymentId = Convert.ToInt32(reader.GetAttribute("memo"));
						liveGamerTransactionInfo.PurchaseOrderId = Convert.ToInt32(reader.GetAttribute("id"));
						break;
					}
					case "buyerUser":
						liveGamerTransactionInfo.UserId = Convert.ToInt32(reader.GetAttribute("externalKey"));
						break;
					case "lineItem":
					{
						LiveGamerLineItem lineItem = new LiveGamerLineItem
						{
							Quantity = Convert.ToInt32(reader.GetAttribute("quantity")),
							Description = reader.GetAttribute("description"),
							Id = Convert.ToInt32(reader.GetAttribute("externalKey").Remove(0, "RobloxItem_".Length))
						};
						lineItems.Add(lineItem);
						break;
					}
					case "payment":
						liveGamerTransactionInfo.Currency = reader.GetAttribute("currency");
						liveGamerTransactionInfo.TaxModel = reader.GetAttribute("taxModel");
						liveGamerTransactionInfo.PaymentType = reader.GetAttribute("paymentType");
						liveGamerTransactionInfo.AmountPaid = Convert.ToDecimal(reader.GetAttribute("amountPaid"));
						liveGamerTransactionInfo.Tax = Convert.ToDecimal(reader.GetAttribute("tax"));
						liveGamerTransactionInfo.Price = Convert.ToDecimal(reader.GetAttribute("price"));
						break;
					}
				}
			}
		}
		liveGamerTransactionInfo.LineItems = lineItems;
		return liveGamerTransactionInfo;
	}
}
