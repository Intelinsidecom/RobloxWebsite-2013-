using System;
using System.Collections.Generic;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Avatar;

internal class AvatarFactory : IAvatarFactory, IDisposable
{
	private readonly IUserFactory _UserFactory;

	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private HashSet<Roblox.Platform.Assets.AssetType> _FullyQualifiedOutfitAssetTypeIds;

	private bool _Disposed;

	public event Action<AvatarChangedEventArgs> AppearanceChangedEvent;

	public AvatarFactory(IUserFactory userFactory, AvatarDomainFactories avatarDomainFactories)
	{
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.FullyQualifiedOutfitAssetTypesCSV, UpdateFullyQualifiedSet);
		if (_AvatarDomainFactories.TrackingEnabled())
		{
			_AvatarDomainFactories.AvatarTracker.RegisterToDiag(this);
			_AvatarDomainFactories.AvatarTracker.RegisterToEventStream(this);
			_Disposed = false;
		}
	}

	public void InvokeAppearanceChangeEvent(AvatarChangedEventArgs args)
	{
		this.AppearanceChangedEvent?.Invoke(args);
	}

	public IAvatar GetAvatar(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		return new Avatar(user, _FullyQualifiedOutfitAssetTypeIds, _AvatarDomainFactories);
	}

	public IAvatar GetAvatar(long userId)
	{
		return GetAvatar(_UserFactory.GetUser(userId));
	}

	private void UpdateFullyQualifiedSet()
	{
		try
		{
			HashSet<Roblox.Platform.Assets.AssetType> result = new HashSet<Roblox.Platform.Assets.AssetType>();
			string[] array = Settings.Default.FullyQualifiedOutfitAssetTypesCSV.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				Roblox.Platform.Assets.AssetType? toAdd = EnumUtils.StrictTryParseEnum<Roblox.Platform.Assets.AssetType>(array[i].Trim());
				if (toAdd.HasValue)
				{
					result.Add(toAdd.Value);
				}
			}
			_FullyQualifiedOutfitAssetTypeIds = result;
		}
		catch (Exception ex)
		{
			_AvatarDomainFactories.Logger.Error(ex);
		}
	}

	private void ReleaseUnmanagedResources()
	{
		if (_AvatarDomainFactories.TrackingEnabled() && !_Disposed)
		{
			_AvatarDomainFactories.AvatarTracker.UnregisterFromDiag(this);
			_AvatarDomainFactories.AvatarTracker.UnregisterFromDiag(this);
			_Disposed = true;
		}
	}

	public void Dispose()
	{
		ReleaseUnmanagedResources();
		GC.SuppressFinalize(this);
	}

	~AvatarFactory()
	{
		ReleaseUnmanagedResources();
	}
}
