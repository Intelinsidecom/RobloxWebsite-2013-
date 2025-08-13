using System;
using Roblox.Platform.Badges.Exceptions;
using Roblox.Platform.Badges.Properties;
using Roblox.Platform.Core;
using Roblox.TextFilter.Client;
using Roblox.TextFilter.Client.Models.Common;

namespace Roblox.Platform.Badges;

public class BadgeTextFilter : IBadgeTextFilter
{
	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly ISettings _Settings;

	public BadgeTextFilter(ISettings settings, ITextFilterClientV2 textFilterClientV2)
	{
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_TextFilterClientV2 = textFilterClientV2 ?? throw new PlatformArgumentNullException("textFilterClientV2");
	}

	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same Author.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Badges.BadgeTextFilterRequest" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Badges.BadgeTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	public BadgeTextFilterResult FilterBadgeText(BadgeTextFilterRequest request)
	{
		if (request == null)
		{
			throw new PlatformArgumentNullException("request");
		}
		if (request.TextAuthor == null)
		{
			throw new PlatformArgumentNullException("Request has no Author");
		}
		try
		{
			return Filter(request);
		}
		catch (Exception ex)
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
	}

	internal virtual BadgeTextFilterResult Filter(BadgeTextFilterRequest request)
	{
		FilterTextResult filteredNameResult = _TextFilterClientV2.FilterObjectName(request.Name, request.TextAuthor, TextFilterServerType.WebAsset, "", true);
		FilterTextResult filteredDescriptionResult = _TextFilterClientV2.FilterObjectName(request.Description, request.TextAuthor, TextFilterServerType.WebAsset, "", true);
		if (_Settings.IsBadgeWithFullyModeratedTextBlocked && filteredNameResult.ModerationLevel == 3)
		{
			throw new PlatformBadgeTextFullyModeratedException("Badge Name is fully moderated.");
		}
		if (_Settings.IsBadgeWithFullyModeratedTextBlocked && filteredDescriptionResult.ModerationLevel == 3)
		{
			throw new PlatformBadgeTextFullyModeratedException("Badge Description is fully moderated.");
		}
		string filteredName = filteredNameResult.FilteredText;
		string filteredDesc = filteredDescriptionResult.FilteredText;
		if (filteredNameResult.ModerationLevel != 3 && filteredDescriptionResult.ModerationLevel != 3)
		{
			FilterTextResult combinedFilteredResult = _TextFilterClientV2.FilterObjectName(request.Name + "\n" + request.Description, request.TextAuthor, TextFilterServerType.WebAsset, "", true);
			if (!combinedFilteredResult.FilteredText.Contains(filteredNameResult.FilteredText) || !combinedFilteredResult.FilteredText.Contains(filteredDescriptionResult.FilteredText))
			{
				if (_Settings.IsBadgeWithFullyModeratedTextBlocked)
				{
					throw new PlatformBadgeTextFullyModeratedException("Badge Name & Description are fully moderated.");
				}
				filteredName = new string('#', request.Name.Length);
				filteredDesc = new string('#', request.Description.Length);
			}
		}
		return new BadgeTextFilterResult
		{
			Name = filteredName,
			Description = filteredDesc
		};
	}
}
