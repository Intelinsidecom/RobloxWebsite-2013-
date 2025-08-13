using System;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;
using Roblox.TextFilter.Client;
using Roblox.TextFilter.Client.Models.Common;

namespace Roblox.Platform.Assets;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.Assets.IAssetTextFilter" /> which uses the TextFilterClientV2.
/// </summary>
internal class AssetTextFilterV2 : IAssetTextFilter
{
	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly ISettings _Settings;

	private bool IsAssetWithFullyModeratedTextBlocked => _Settings.IsAssetWithFullyModeratedTextBlocked;

	public AssetTextFilterV2(ITextFilterClientV2 textFilterClientV2, ISettings settings)
	{
		_TextFilterClientV2 = textFilterClientV2 ?? throw new PlatformArgumentNullException("textFilterClientV2");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public IAssetTextFilterResult FilterAssetText(IAssetTextFilterRequest request)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same Author.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Assets.IAssetTextFilterRequestV2" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Assets.IAssetTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	public IAssetTextFilterResult FilterAssetText(IAssetTextFilterRequestV2 request)
	{
		ValidateRequest(request);
		if (!_Settings.AssetCreationNoContextEnabled)
		{
			return FilterTextWithContext(request);
		}
		return FilterTextNoContext(request);
	}

	internal virtual void ValidateRequest(IAssetTextFilterRequestV2 request)
	{
		if (request == null)
		{
			throw new PlatformArgumentNullException("request");
		}
		if (request.ClientTextAuthor == null)
		{
			throw new PlatformArgumentNullException("Request has no Author");
		}
	}

	internal virtual IAssetTextFilterResult FilterTextWithContext(IAssetTextFilterRequestV2 request)
	{
		string room = Guid.NewGuid().ToString();
		try
		{
			FilterTextResult nameFilteredResult = _TextFilterClientV2.FilterObjectName(request.Name, request.ClientTextAuthor, TextFilterServerType.WebAsset, room, false);
			if (IsAssetWithFullyModeratedTextBlocked && nameFilteredResult.ModerationLevel == 3)
			{
				throw new PlatformAssetTextFullyModeratedException("Asset Name is fully moderated.");
			}
			FilterTextResult descriptionFilteredResult = _TextFilterClientV2.FilterObjectName(request.Description, request.ClientTextAuthor, TextFilterServerType.WebAsset, room, false);
			if (IsAssetWithFullyModeratedTextBlocked && descriptionFilteredResult.ModerationLevel == 3)
			{
				throw new PlatformAssetTextFullyModeratedException("Asset Description is fully moderated.");
			}
			return new AssetTextFilterResult(nameFilteredResult.FilteredText, descriptionFilteredResult.FilteredText);
		}
		catch (Exception ex) when (!(ex is PlatformAssetTextFullyModeratedException))
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
	}

	internal virtual IAssetTextFilterResult FilterTextNoContext(IAssetTextFilterRequestV2 request)
	{
		try
		{
			FilterTextResult nameFilteredResult = _TextFilterClientV2.FilterObjectName(request.Name, request.ClientTextAuthor, TextFilterServerType.WebAsset, "", true);
			if (IsAssetWithFullyModeratedTextBlocked && nameFilteredResult.ModerationLevel == 3)
			{
				throw new PlatformAssetTextFullyModeratedException("Asset Name is fully moderated.");
			}
			FilterTextResult descriptionFilteredResult = _TextFilterClientV2.FilterObjectName(request.Description, request.ClientTextAuthor, TextFilterServerType.WebAsset, "", true);
			if (IsAssetWithFullyModeratedTextBlocked && descriptionFilteredResult.ModerationLevel == 3)
			{
				throw new PlatformAssetTextFullyModeratedException("Asset Description is fully moderated.");
			}
			if (nameFilteredResult.ModerationLevel != 3 && descriptionFilteredResult.ModerationLevel != 3)
			{
				FilterTextResult combinedFilteredResult = _TextFilterClientV2.FilterObjectName(request.Name + "\n" + request.Description, request.ClientTextAuthor, TextFilterServerType.WebAsset, "", true);
				if (nameFilteredResult.ModerationLevel == 1 && descriptionFilteredResult.ModerationLevel == 1 && combinedFilteredResult.ModerationLevel == 1)
				{
					return new AssetTextFilterResult(nameFilteredResult.FilteredText, descriptionFilteredResult.FilteredText);
				}
				if (!combinedFilteredResult.FilteredText.Contains(nameFilteredResult.FilteredText) || !combinedFilteredResult.FilteredText.Contains(descriptionFilteredResult.FilteredText))
				{
					throw new PlatformAssetTextFullyModeratedException("Asset Name & Description is fully moderated.");
				}
			}
			return new AssetTextFilterResult(nameFilteredResult.FilteredText, descriptionFilteredResult.FilteredText);
		}
		catch (Exception ex) when (!(ex is PlatformAssetTextFullyModeratedException))
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
	}
}
