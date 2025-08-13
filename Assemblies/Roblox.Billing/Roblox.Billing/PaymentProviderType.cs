using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PaymentProviderType : IRobloxEntity<byte, PaymentProviderTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PaymentProviderTypeDAL _EntityDAL;

	public static readonly PaymentProviderType AppleAppStore;

	public static readonly PaymentProviderType Boku;

	public static readonly PaymentProviderType Check;

	public static readonly PaymentProviderType Credit;

	public static readonly PaymentProviderType CreditCard;

	public static readonly PaymentProviderType GooglePlayStore;

	public static readonly PaymentProviderType InComm;

	public static readonly PaymentProviderType Mail;

	public static readonly PaymentProviderType MidasWeChatAndroid;

	public static readonly PaymentProviderType MidasWeChatApple;

	public static readonly PaymentProviderType MidasWeChatDesktop;

	public static readonly PaymentProviderType Paypal;

	public static readonly PaymentProviderType Rixty;

	public static readonly PaymentProviderType RixtyPin;

	public static readonly PaymentProviderType LiveGamer;

	public static readonly PaymentProviderType ROBLOXGiveaway;

	public static readonly PaymentProviderType AmazonStore;

	public static readonly PaymentProviderType XboxStore;

	public static readonly PaymentProviderType WindowsStore;

	public static readonly PaymentProviderType VantivToken;

	public static readonly PaymentProviderType XsollaOXXO;

	public static readonly PaymentProviderType XsollaBoleto;

	public static readonly PaymentProviderType XsollaSOFORT;

	public static readonly PaymentProviderType XsollaCreditDebitCards;

	public static readonly PaymentProviderType XsollaAmazonPay;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public bool SupportsRecurringCharges
	{
		get
		{
			return _EntityDAL.SupportsRecurringCharges;
		}
		set
		{
			_EntityDAL.SupportsRecurringCharges = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PaymentProviderType()
	{
		_EntityDAL = new PaymentProviderTypeDAL();
	}

	static PaymentProviderType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "PaymentProviderType", isNullCacheable: true);
		AppleAppStore = Get("Apple App Store");
		Boku = Get("Boku");
		Check = Get("PayPal Express Checkout eCheck");
		Credit = Get("Credit");
		CreditCard = Get("Website Payments Pro Payflow Edition");
		GooglePlayStore = Get("Google Play Store");
		InComm = Get("InComm");
		Mail = Get("Pay by Mail Direct");
		MidasWeChatAndroid = Get("Midas.WeChat.Android");
		MidasWeChatApple = Get("Midas.WeChat.Apple");
		MidasWeChatDesktop = Get("Midas.WeChat.Desktop");
		Paypal = Get("PayPal Express Checkout");
		Rixty = Get("Rixty");
		RixtyPin = Get("RixtyPin");
		LiveGamer = Get("LiveGamer");
		ROBLOXGiveaway = Get("ROBLOX Giveaway");
		AmazonStore = Get("Amazon Store");
		XboxStore = Get("Xbox Store");
		WindowsStore = Get("Windows Store");
		VantivToken = Get("VantivToken");
		XsollaCreditDebitCards = Get("Xsolla.CreditDebitCards");
		XsollaOXXO = Get("Xsolla.OXXO");
		XsollaBoleto = Get("Xsolla.Boleto");
		XsollaSOFORT = Get("Xsolla.SOFORT");
		XsollaAmazonPay = Get("Xsolla.AmazonPay");
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static PaymentProviderType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PaymentProviderTypeDAL, PaymentProviderType>(EntityCacheInfo, id, () => PaymentProviderTypeDAL.Get(id));
	}

	public static PaymentProviderType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PaymentProviderTypeDAL, PaymentProviderType>(EntityCacheInfo, "Value:" + value, () => PaymentProviderTypeDAL.Get(value));
	}

	public static ICollection<PaymentProviderType> GetPaymentProviderTypesPaged(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetPaymentProviderTypes_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysAll()), collectionId, () => PaymentProviderTypeDAL.GetPaymentProviderTypesByID_Paged((byte)(startRowIndex + 1), maximumRows), MultiGet);
	}

	internal static byte GetTotalNumberOfPaymentProviderTypes()
	{
		string countId = "GetTotalNumberOfPaymentProviderTypes";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysAll()), countId, PaymentProviderTypeDAL.GetTotalNumberOfPaymentProviderTypes);
	}

	public static ICollection<PaymentProviderType> GetAllPaymentProviderTypes()
	{
		return GetPaymentProviderTypesPaged(0, byte.MaxValue);
	}

	private static ICollection<PaymentProviderType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, PaymentProviderTypeDAL, PaymentProviderType>(ids, EntityCacheInfo, PaymentProviderTypeDAL.MultiGet);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Construct(PaymentProviderTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysAll());
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}

	private static string GetLookupCacheKeysAll()
	{
		return "GetAll";
	}
}
