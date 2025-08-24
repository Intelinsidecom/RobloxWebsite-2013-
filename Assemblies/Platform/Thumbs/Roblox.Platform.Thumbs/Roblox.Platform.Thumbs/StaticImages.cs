using System;
using System.Collections.Concurrent;
using Roblox.Platform.Core;
using Roblox.Thumbnails.Client;
using Roblox.Thumbs.Properties;

namespace Roblox.Thumbs;

public class StaticImages : DomainObjectBase<ThumbnailDomainFactories>, IStaticImages
{
	private const int _StaticImagePseudoAssetHashId = -1000;

	private const int _MinGameIconIndex = 1;

	private const int _MaxGameIconIndex = 12;

	private const int _MinGameMediaItemIndex = 1;

	private const int _MaxGameMediaItemIndex = 12;

	private readonly ConcurrentDictionary<string, string> _StaticImages = new ConcurrentDictionary<string, string>();

	public StaticImages(ThumbnailDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	public ThumbResult GetUnavailableThumbResult(int width, int height, string format)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return new ThumbResult
		{
			final = false,
			GetUrl = (bool secureConnection) => GetStaticImageUrl("UnavailableImage", width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)4
		};
	}

	public ThumbResult GetBrokenThumbResult(int width, int height, string format)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return new ThumbResult
		{
			final = true,
			GetUrl = (bool secureConnection) => GetStaticImageUrl("BrokenImage", width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)3
		};
	}

	public ThumbResult GetUnapprovedThumbResult(int width, int height, string format)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return new ThumbResult
		{
			final = true,
			GetUrl = (bool secureConnection) => GetStaticImageUrl("UnapprovedImage", width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)1
		};
	}

	public ThumbResult GetUnreviewedThumbResult(int width, int height, string format)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return new ThumbResult
		{
			final = true,
			GetUrl = (bool secureConnection) => GetStaticImageUrl("UnreviewedImage", width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)2
		};
	}

	public ThumbResult GetUnknownThumbResult(int width, int height, string format)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		return new ThumbResult
		{
			final = true,
			GetUrl = (bool secureConnection) => GetStaticImageUrl("UnknownImage", width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)5
		};
	}

	/// <summary>
	/// Gets game icon thumbnail result by given size, format and index.
	/// </summary>
	/// <param name="width">The width of the thumbnail.</param>
	/// <param name="height">The height of the thumbnail.</param>
	/// <param name="format">The format of the thumbnail.</param>
	/// <param name="index">The index of the game icon. Minimum value is 1 and maximum value is 12.</param>
	/// <returns>Returns the game icon thumbnail result by given size, format and index.</returns>
	public ThumbResult GetGameIconThumbResult(int width, int height, string format, int index)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (index < 1 || index > 12)
		{
			throw new ArgumentException("index");
		}
		string thumbnailType = "GameIcon" + index;
		return new ThumbResult
		{
			final = true,
			GetUrl = (bool secureConnection) => GetStaticImageUrl(thumbnailType, width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)0
		};
	}

	/// <summary>
	/// Gets game media item thumbnail result by given size, format and index.
	/// </summary>
	/// <param name="width">The width of the thumbnail.</param>
	/// <param name="height">The height of the thumbnail.</param>
	/// <param name="format">The format of the thumbnail.</param>
	/// <param name="index">The index of the game media item. Minimum value is 1 and maximum value is 12.</param>
	/// <returns>Returns the game media item thumbanil result by given size, format and index.</returns>
	public ThumbResult GetGameMediaItemThumbResult(int width, int height, string format, int index)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		if (index < 1 || index > 12)
		{
			throw new ArgumentException("index");
		}
		string thumbnailType = "GameMediaItem" + index;
		return new ThumbResult
		{
			final = true,
			GetUrl = (bool secureConnection) => GetStaticImageUrl(thumbnailType, width, height, format, secureConnection),
			SubstitutionType = (SubstitutionType)0
		};
	}

	private string GetStaticImageUrl(string thumbnailType, int width, int height, string format, bool secure)
	{
		if (format == ThumbnailConstants.ObjFormat)
		{
			return null;
		}
		string key = thumbnailType + "-" + width + "x" + height + "." + format + "|" + secure.ToString();
		if (!_StaticImages.TryGetValue(key, out var url))
		{
			try
			{
				ThumbnailHashResult thumbnailHashResult = base.DomainFactories.ThumbnailsClient.GetThumbnailHash(-1000L, thumbnailType, width, height, format, (long?)null);
				if (!string.IsNullOrWhiteSpace(thumbnailHashResult.Hash))
				{
					url = base.DomainFactories.ThumbnailRepository.GetThumbnailUrl(thumbnailHashResult.Hash, secure);
					_StaticImages[key] = url;
				}
				else
				{
					url = (secure ? Settings.Default.EmptyPixelHttpsUrl : Settings.Default.EmptyPixelHttpUrl);
				}
			}
			catch (Exception e)
			{
				base.DomainFactories.Logger.Error(e);
				url = (secure ? Settings.Default.EmptyPixelHttpsUrl : Settings.Default.EmptyPixelHttpUrl);
			}
		}
		return url;
	}
}
