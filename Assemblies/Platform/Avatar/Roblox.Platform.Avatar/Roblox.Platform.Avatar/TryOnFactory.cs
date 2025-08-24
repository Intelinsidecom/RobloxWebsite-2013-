using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.Avatar;

public class TryOnFactory : ITryOnFactory, IDisposable
{
	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly DefaultClothingEnforcer _DefaultClothingEnforcer;

	private bool _Disposed;

	public event Action<AvatarChangedEventArgs> TryOnEvent;

	public TryOnFactory(AvatarDomainFactories avatarDomainFactories)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_DefaultClothingEnforcer = new DefaultClothingEnforcer();
		if (_AvatarDomainFactories.TrackingEnabled())
		{
			_AvatarDomainFactories.AvatarTracker.RegisterToDiag(this);
			_AvatarDomainFactories.AvatarTracker.RegisterToEventStream(this);
			_Disposed = false;
		}
	}

	public IOutfit GetTemporaryOutfit(ICollection<Roblox.Platform.Assets.IAsset> wearableAssets, IUser user, bool applyDefaultClothing = true, bool trackUsage = true)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (wearableAssets == null || wearableAssets.Count == 0)
		{
			throw new PlatformArgumentNullException("wearableAssets");
		}
		IAvatar avatar = _AvatarDomainFactories.AvatarFactory.GetAvatar(user);
		IBrickBodyColorSet brickBodyColorSet = avatar.GetBodyColors();
		long? bodyColorSetId = avatar.GetBodyColorSetId();
		IBodyColorSet bodyColorSet = _AvatarDomainFactories.OutfitDomainFactories.BodyColorSetFactory.GetById(bodyColorSetId.Value);
		PlayerAvatarType playerAvatarType = avatar.GetPlayerAvatarType();
		IAvatarScale avatarScale = avatar.GetScale();
		Scale scale = _AvatarDomainFactories.OutfitDomainFactories.ScaleFactory.GetOrCreate(avatarScale.Height, avatarScale.Width, avatarScale.Head, avatarScale.Proportion, avatarScale.BodyType);
		AccoutrementSetBuilder accoutrementSetBuilder = new AccoutrementSetBuilder(user, _AvatarDomainFactories);
		accoutrementSetBuilder.LoadAccoutrements();
		foreach (Roblox.Platform.Assets.IAsset asset in wearableAssets)
		{
			if (!IsAssetEligibleForTryingOn(asset))
			{
				throw new PlatformArgumentException($"Trying on assetId={asset.Id} of typeId={asset.TypeId} failed. Asset type is not wearable.");
			}
			accoutrementSetBuilder.Add(asset, checkOwnership: false);
			accoutrementSetBuilder.EnforceWearingLimits(AccessoryLimitModeEnum.TenTotalAccessories);
			if (trackUsage)
			{
				try
				{
					AvatarChangedEventArgs eventArgs = new AvatarChangedEventArgs(user.Id, AvatarChangeTypeEnum.TryOn, asset.Id, asset.TypeId);
					this.TryOnEvent?.Invoke(eventArgs);
				}
				catch (Exception ex)
				{
					_AvatarDomainFactories.Logger.Warning(ex.ToString());
				}
			}
		}
		accoutrementSetBuilder.FilterDuplicates();
		IList<Roblox.Platform.Assets.IAsset> temporaryOutfitAssets = accoutrementSetBuilder.GetAssets().ToList();
		temporaryOutfitAssets = _DefaultClothingEnforcer.TryAddDefaultClothing(user, temporaryOutfitAssets, brickBodyColorSet, _AvatarDomainFactories.AssetFactory);
		return _AvatarDomainFactories.OutfitDomainFactories.TemporaryOutfitFactory.Create(temporaryOutfitAssets.Select((Roblox.Platform.Assets.IAsset x) => x.Id).ToList(), bodyColorSet, scale, playerAvatarType, user);
	}

	public bool IsAssetEligibleForTryingOn(Roblox.Platform.Assets.IAsset asset)
	{
		if (asset == null)
		{
			throw new PlatformArgumentNullException("asset");
		}
		if (DelayedReleaseAsset.IsDelayedAsset(asset.Id))
		{
			throw new TryOnDelayedReleaseAssetException($"Trying on assetId={asset.Id} of typeId={asset.TypeId} failed. Asset cannot be accessed.");
		}
		if (!Asset.Get(asset.Id).IsApproved)
		{
			return false;
		}
		return _AvatarDomainFactories.AccoutrementRulesAuthority.CanTryOn(asset.TypeId);
	}

	private void ReleaseUnmanagedResources()
	{
		if (_AvatarDomainFactories.TrackingEnabled() && !_Disposed)
		{
			_AvatarDomainFactories.AvatarTracker.UnregisterFromDiag(this);
			_AvatarDomainFactories.AvatarTracker.UnregisterFromEventStream(this);
			_Disposed = true;
		}
	}

	public void Dispose()
	{
		ReleaseUnmanagedResources();
		GC.SuppressFinalize(this);
	}

	~TryOnFactory()
	{
		ReleaseUnmanagedResources();
	}
}
