using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Assets.Client;
using Roblox.EventLog;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

/// <inheritdoc />
internal class AssetOptionFactory : IAssetOptionFactory
{
	private static IAssetOptionFactory _Singleton;

	private readonly IUntestableCodeWrapper _UntestableCodeWrapper;

	private readonly IAssetsClient _AssetsClient;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	[Obsolete("Use AssetDomainFactories.AssetOptionFactory instead.")]
	internal static IAssetOptionFactory Singleton
	{
		get
		{
			if (_Singleton == null)
			{
				_Singleton = Factories.DomainFactories.AssetOptionFactory;
			}
			return _Singleton;
		}
		set
		{
			_Singleton = value;
		}
	}

	/// <summary>
	/// Legacy constructor - do not use.
	/// </summary>
	[Obsolete("To be removed. Use AssetOptionFactory(IAssetsClient, ILogger) constructor instead.")]
	public AssetOptionFactory()
		: this(Factories.DomainFactories.AssetsClient, Settings.Default, Factories.DomainFactories.Logger, new UntestableCodeWrapper())
	{
	}

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="assetsClient">Assets service client.</param>
	/// <param name="logger">Roblox event logger.</param>
	public AssetOptionFactory(IAssetsClient assetsClient, ILogger logger)
		: this(assetsClient, Settings.Default, logger, new UntestableCodeWrapper())
	{
	}

	/// <summary>
	/// Injection constructor.
	/// </summary>
	/// <param name="assetsClient">Assets service client.</param>
	/// <param name="settings">Platform Assets settings <see cref="T:Roblox.Platform.Assets.Properties.ISettings" /></param>
	/// <param name="logger">Roblox event logger.</param>
	/// <param name="untestableCodeWrapper"></param>
	internal AssetOptionFactory(IAssetsClient assetsClient, ISettings settings, ILogger logger, IUntestableCodeWrapper untestableCodeWrapper)
	{
		_AssetsClient = assetsClient ?? throw new ArgumentNullException("assetsClient");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentException("logger");
		_UntestableCodeWrapper = untestableCodeWrapper ?? throw new ArgumentNullException("untestableCodeWrapper");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IAssetOptionFactory.Get(System.Int64)" />
	public IAssetOption Get(long id)
	{
		if (Math.Abs(id % 100) < _Settings.UseAssetsServiceForAssetOptionFactoryGetRolloutPercentage)
		{
			try
			{
				GetAssetOptionResponse response = Task.Run<GetAssetOptionResponse>(async () => await _AssetsClient.GetAssetOptionByAssetIdAsync(id, CancellationToken.None)).Result;
				return ConvertFromAssetServiceResponse(response);
			}
			catch (Exception ex)
			{
				_Logger.Error($"Failed to get asset option via Assets service: {ex}");
			}
		}
		return _UntestableCodeWrapper.Execute(() => GetAssetOption(Roblox.AssetOption.Get(id)), "SCL Call");
	}

	/// <inheritdoc cref="T:Roblox.Platform.Assets.IAssetOptionFactory" />
	public IAssetOption GetOrCreate(long assetId)
	{
		if (Math.Abs(assetId % 100) < _Settings.UseAssetsServiceForAssetOptionFactoryGetOrCreateRolloutPercentage)
		{
			try
			{
				GetAssetOptionResponse response = Task.Run<GetAssetOptionResponse>(async () => await _AssetsClient.GetOrCreateAssetOptionAsync(assetId, CancellationToken.None)).Result;
				return ConvertFromAssetServiceResponse(response);
			}
			catch (Exception ex)
			{
				_Logger.Error($"Failed to get or create asset option via Assets service: {ex}");
			}
		}
		return _UntestableCodeWrapper.Execute(() => GetAssetOption(Roblox.AssetOption.GetOrCreate(assetId)), "SCL GetOrCreate Call");
	}

	/// <inheritdoc cref="T:Roblox.Platform.Assets.IAssetOptionFactory" />
	public IAssetOption GetAssetOption(Roblox.AssetOption sclOption)
	{
		if (sclOption == null)
		{
			return null;
		}
		return new AssetOption
		{
			Id = sclOption.ID,
			AssetId = sclOption.AssetID,
			EnableComments = sclOption.EnableComments,
			EnableRatings = sclOption.EnableRatings,
			IsCopyLocked = sclOption.IsCopyLocked,
			IsFriendsOnly = sclOption.IsFriendsOnly,
			AllowedGearCategories = sclOption.AllowedGearCategories,
			DefaultExpirationInTicks = sclOption.DefaultExpirationInTicks,
			EnforceGenre = sclOption.EnforceGenre,
			MinMembershipType = (MembershipType)sclOption.MinMembershipType,
			Created = sclOption.Created,
			Updated = sclOption.Updated
		};
	}

	/// <inheritdoc cref="T:Roblox.Platform.Assets.IAssetOptionFactory" />
	public void Save(IAssetOption platformOption)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		long assetId = platformOption.AssetId;
		if (Math.Abs(assetId % 100) < _Settings.UseAssetsServiceForAssetOptionFactorySaveRolloutPercentage)
		{
			try
			{
				UpdateAssetOptionRequest updateRequest = new UpdateAssetOptionRequest(assetId);
				updateRequest.SetEnableComments(platformOption.EnableComments);
				updateRequest.SetEnableRatings(platformOption.EnableRatings);
				updateRequest.SetIsCopyLocked(platformOption.IsCopyLocked);
				updateRequest.SetIsFriendsOnly(platformOption.IsFriendsOnly);
				updateRequest.SetAllowedGearCategories((long)platformOption.AllowedGearCategories);
				updateRequest.SetDefaultExpirationInTicks(platformOption.DefaultExpirationInTicks);
				updateRequest.SetEnforceGenre(platformOption.EnforceGenre);
				updateRequest.SetMinMembershipType((byte)platformOption.MinMembershipType);
				Task.Run<GetAssetOptionResponse>(async () => await _AssetsClient.UpdateOrCreateAssetOptionAsync(updateRequest, CancellationToken.None)).Wait();
				return;
			}
			catch (Exception ex)
			{
				_Logger.Error($"Failed to update or create asset option via Assets service: {ex}");
			}
		}
		_UntestableCodeWrapper.Execute(delegate
		{
			Roblox.AssetOption orCreate = Roblox.AssetOption.GetOrCreate(platformOption.AssetId);
			orCreate.ID = platformOption.Id;
			orCreate.AssetID = platformOption.AssetId;
			orCreate.EnableComments = platformOption.EnableComments;
			orCreate.EnableRatings = platformOption.EnableRatings;
			orCreate.IsCopyLocked = platformOption.IsCopyLocked;
			orCreate.IsFriendsOnly = platformOption.IsFriendsOnly;
			orCreate.AllowedGearCategories = platformOption.AllowedGearCategories;
			orCreate.DefaultExpirationInTicks = platformOption.DefaultExpirationInTicks;
			orCreate.EnforceGenre = platformOption.EnforceGenre;
			orCreate.MinMembershipType = (Roblox.AssetOption.MembershipType)platformOption.MinMembershipType;
			orCreate.Save();
		}, "SCL Save Asset Option");
	}

	private IAssetOption ConvertFromAssetServiceResponse(GetAssetOptionResponse response)
	{
		if (response == null)
		{
			return null;
		}
		return new AssetOption
		{
			Id = response.Id,
			AssetId = response.AssetId,
			EnableComments = response.EnableComments,
			EnableRatings = response.EnableRatings,
			IsCopyLocked = response.IsCopyLocked,
			IsFriendsOnly = response.IsFriendsOnly,
			AllowedGearCategories = (ulong)response.AllowedGearCategories,
			DefaultExpirationInTicks = response.DefaultExpirationInTicks,
			EnforceGenre = response.EnforceGenre,
			MinMembershipType = (MembershipType)response.MinMembershipType,
			Created = response.Created,
			Updated = response.Updated
		};
	}
}
