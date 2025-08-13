using System;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership;

namespace Roblox;

public static class QueryStringAssetParameterParser
{
	private static IAssetOwnershipAuthority _AssetOwnershipAuthority { get; } = new AssetOwnershipAuthority(Asset.LookupAssetTypeId, "ServerClassLibrary", NoOpLogger.Instance);


	public static IAsset ParseAssetFromQuerystring(Uri uri, bool throwIfBadUrl)
	{
		string assetId = null;
		string assetVersionNumber = null;
		string[] array = uri.GetComponents(UriComponents.Query, UriFormat.Unescaped).Split('&');
		for (int i = 0; i < array.Length; i++)
		{
			string[] s = array[i].Split('=');
			switch (s[0].ToLower())
			{
			case "userassetid":
			{
				long userAssetId = Convert.ToInt64(s[1]);
				return Asset.Get(_AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetId).AssetId);
			}
			case "versionid":
			case "assetversionid":
				return AssetVersion.Get(Convert.ToInt64(s[1]));
			case "id":
				assetId = s[1];
				break;
			case "version":
				assetVersionNumber = s[1];
				break;
			}
		}
		if (assetId != null && assetVersionNumber != null)
		{
			return AssetVersion.Get(Convert.ToInt64(assetId), Convert.ToInt32(assetVersionNumber));
		}
		if (assetId != null)
		{
			return Asset.Get(Convert.ToInt64(assetId));
		}
		if (throwIfBadUrl)
		{
			throw new ArgumentException();
		}
		return null;
	}

	public static long? ParseAssetIdFromQueryString(Uri uri, bool throwIfBadUrl)
	{
		string assetId = null;
		string assetVersionNumber = null;
		string[] array = uri.GetComponents(UriComponents.Query, UriFormat.Unescaped).Split('&');
		for (int i = 0; i < array.Length; i++)
		{
			string[] s = array[i].Split('=');
			switch (s[0].ToLower())
			{
			case "userassetid":
			{
				long userAssetId = Convert.ToInt64(s[1]);
				return _AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetId).AssetId;
			}
			case "versionid":
			case "assetversionid":
				return AssetVersion.Get(Convert.ToInt64(s[1])).AssetID;
			case "id":
				assetId = s[1];
				break;
			case "version":
				assetVersionNumber = s[1];
				break;
			}
		}
		if (assetId != null && assetVersionNumber != null)
		{
			return AssetVersion.Get(Convert.ToInt64(assetId), Convert.ToInt32(assetVersionNumber)).AssetID;
		}
		if (assetId != null)
		{
			return Convert.ToInt64(assetId);
		}
		if (throwIfBadUrl)
		{
			throw new ArgumentException();
		}
		return null;
	}

	public static AssetReference ParseAssetReferenceFromQuerystring(Uri uri, bool throwIfBadUrl)
	{
		string assetId = null;
		string assetVersionNumber = null;
		string[] array = uri.GetComponents(UriComponents.Query, UriFormat.Unescaped).Split('&');
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=');
			string key = array2[0].ToLower();
			string value = array2[1];
			switch (key)
			{
			case "userassetid":
			{
				long userAssetId = Convert.ToInt64(value);
				IUserAsset userAsset = _AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetId);
				if (userAsset != null)
				{
					return new AssetReference(Asset.Get(userAsset.AssetId), AssetReference.AssetReferenceTypes.AssetSubscription);
				}
				break;
			}
			case "versionid":
			case "assetversionid":
			{
				AssetVersion av = AssetVersion.Get(Convert.ToInt64(value));
				if (av != null)
				{
					return new AssetReference(av.Asset, AssetReference.AssetReferenceTypes.AssetSubscription);
				}
				break;
			}
			case "id":
				assetId = value;
				break;
			case "version":
				assetVersionNumber = value;
				break;
			}
		}
		if (assetId != null && assetVersionNumber != null)
		{
			AssetVersion av2 = AssetVersion.Get(Convert.ToInt64(assetId), Convert.ToInt32(assetVersionNumber));
			if (av2 != null)
			{
				return new AssetReference(av2, AssetReference.AssetReferenceTypes.AssetVersion);
			}
		}
		if (assetId != null)
		{
			Asset a = Asset.Get(Convert.ToInt64(assetId));
			if (a != null)
			{
				return new AssetReference(a, AssetReference.AssetReferenceTypes.AssetSubscription);
			}
		}
		if (throwIfBadUrl)
		{
			throw new ArgumentException();
		}
		return null;
	}
}
