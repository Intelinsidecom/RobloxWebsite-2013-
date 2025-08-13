using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <summary>
/// This is a wrapper around a singleton
/// Use AssetDomainFactories.AssetFactory for new code
/// </summary>
[Obsolete("Use AssetDomainFactories.AssetFactory for new code")]
public class AssetFactory
{
	/// <summary>
	/// Always access the singleton through the internal Singleton property or the public GetSingleton() method.
	/// Never directly access the private _Singleton field because it may not be initialized yet.
	/// </summary>
	private static AssetFactoryInstantiable _Singleton;

	internal static AssetFactoryInstantiable Singleton
	{
		get
		{
			if (_Singleton == null)
			{
				_Singleton = Factories.DomainFactories.AssetFactoryInternal;
			}
			return _Singleton;
		}
		set
		{
			_Singleton = value;
		}
	}

	public static IAssetFactory GetSingleton()
	{
		return Singleton;
	}

	[Obsolete("Universal Asset creation is deprecated and can lead to runtime failures.  This function will throw for numerous AssetTypes, because more information is required.  Choose a type-specific creation method instead.")]
	public static IAsset Create(int assetTypeId, IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		return GetSingleton().Create(assetTypeId, assetNameAndDescription, assetCreatorInfo, stream, actorUserIdentity);
	}

	[Obsolete("Universal Asset creation is deprecated and can lead to runtime failures.  This function will throw for numerous AssetTypes, because more information is required.  Choose a type-specific creation method instead.")]
	public static IAsset Create(int assetTypeId, IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity)
	{
		return GetSingleton().Create(assetTypeId, assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity);
	}

	public static IAsset CheckedGetAsset(long? id)
	{
		return GetSingleton().CheckedGetAsset(id);
	}

	public static IAsset GetAsset(long? id)
	{
		return GetSingleton().GetAsset(id);
	}
}
