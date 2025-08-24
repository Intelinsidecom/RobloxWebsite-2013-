using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Roblox.Drawing;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

[Obsolete("Use Roblox.Platform.GamePasses.Core.GamePassFactory")]
public class GamePassFactory : AssetFactoryBase<IGamePass>, IGamePassFactory, IAssetFactoryBase<IGamePass>
{
	private static readonly List<Tuple<Point, byte>> _AntiAliasedTransparentPixels;

	private const int _Size = 150;

	private static readonly Size _BadgeSize;

	protected override int AssetTypeId => Roblox.AssetType.GamePassID;

	static GamePassFactory()
	{
		_BadgeSize = new Size(150, 150);
		_AntiAliasedTransparentPixels = ImageUtil.GetTransparentPixelsForCircularCutout(150).ToList();
	}

	internal GamePassFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	private IRawContent CreateRawContent(CreatorType creatorType, long creatorTargetId)
	{
		byte[] guid = Guid.NewGuid().ToByteArray();
		using MemoryStream itemStream = new MemoryStream();
		itemStream.Write(guid, 0, guid.Length);
		itemStream.Seek(0L, SeekOrigin.Begin);
		return base.DomainFactories.RawContentFactory.GetOrCreate(AssetTypeId, creatorType, creatorTargetId, itemStream);
	}

	protected override IGamePass BuildChildAsset(IAsset genericAsset)
	{
		return new GamePass(base.DomainFactories, genericAsset);
	}

	internal IGamePass GetGamePass(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	public void UpdateGamePassImage(long gamePassId, long imageId)
	{
		PlaceGamePass placeGamePass = PlaceGamePass.GetPlaceGamePassesByPassID(gamePassId, 1, 1).FirstOrDefault();
		if (placeGamePass != null)
		{
			placeGamePass.ImageID = imageId;
			placeGamePass.Save();
			return;
		}
		throw new InvalidOperationException("PlaceGamePass not found for PassId! : " + gamePassId);
	}

	public IGamePass CreateGamePass(AssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IImage image, IPlace place, IUserIdentifier actorUserIdentity)
	{
		IRawContent rawContent = CreateRawContent(assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId);
		IGamePass gamePass = Create(assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity);
		PlaceGamePass placeGamePass = new PlaceGamePass();
		placeGamePass.PlaceID = place.Id;
		placeGamePass.PassID = gamePass.Id;
		placeGamePass.ImageID = image.Id;
		placeGamePass.Save();
		return gamePass;
	}

	public static Stream DrawGamePassImage(Stream texture)
	{
		return ImageUtil.ReshapeToCircularImage(texture, _AntiAliasedTransparentPixels, _BadgeSize);
	}

	public long GetTotalNumberOfGamePassesByPlaceId(long placeId)
	{
		return PlaceGamePass.GetTotalNumberOfPlaceGamePassesByPlaceID(placeId);
	}

	public ICollection<IGamePass> GetGamePassesByPlaceId_Paged(long placeId, int startRowIndex, int maximumRows)
	{
		if (placeId == 0L)
		{
			throw new ArgumentException("placeId");
		}
		if (startRowIndex <= 0)
		{
			throw new ArgumentOutOfRangeException("startRowIndex");
		}
		if (maximumRows <= 0)
		{
			throw new ArgumentOutOfRangeException("maximumRows");
		}
		return (from pass in PlaceGamePass.GetPlaceGamePassesByPlaceID(placeId, startRowIndex, maximumRows)
			select Get(pass.PassID)).ToArray();
	}
}
