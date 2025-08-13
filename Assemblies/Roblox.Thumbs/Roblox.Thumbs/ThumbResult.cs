using System;
using Roblox.Thumbnails.Client;

namespace Roblox.Thumbs;

public class ThumbResult
{
	public bool final;

	public Func<bool, string> GetUrl;

	public SubstitutionType SubstitutionType;

	public static ThumbResult Create(int width, int height, string format, ThumbnailHashResult thumbnailHashResult, ThumbnailDomainFactories domainFactories)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		ThumbnailHashResult obj = thumbnailHashResult;
		if (((obj != null) ? obj.Hash : null) != null)
		{
			if (thumbnailHashResult.Hash == string.Empty)
			{
				return domainFactories.StaticImages.GetBrokenThumbResult(width, height, format);
			}
			return new ThumbResult
			{
				final = true,
				GetUrl = (bool secureConnection) => (!string.IsNullOrWhiteSpace(thumbnailHashResult.Url)) ? thumbnailHashResult.Url : LookupUrl(thumbnailHashResult.Hash, secureConnection, domainFactories),
				SubstitutionType = thumbnailHashResult.SubstitutionType
			};
		}
		return domainFactories.StaticImages.GetUnavailableThumbResult(width, height, format);
	}

	private static string LookupUrl(string hash, bool secure, ThumbnailDomainFactories domainFactories)
	{
		return domainFactories.ThumbnailRepository.GetThumbnailUrl(hash, secure);
	}
}
