using System;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;
using Roblox.TextFilter;

namespace Roblox.Platform.Assets;

/// <summary>
/// Default internal implementation of <see cref="T:Roblox.Platform.Assets.IAssetTextFilter" />.
/// </summary>
internal class AssetTextFilter : IAssetTextFilter
{
	private readonly ITextFilter _TextFilter;

	private readonly ISettings _Settings;

	private bool IsAssetWithFullyModeratedTextBlocked => _Settings.IsAssetWithFullyModeratedTextBlocked;

	public AssetTextFilter(ITextFilter textFilter, ISettings settings)
	{
		_TextFilter = textFilter ?? throw new PlatformArgumentNullException("textFilter");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same ClientTextAuthor.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Assets.IAssetTextFilterRequestV2" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Assets.IAssetTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	public IAssetTextFilterResult FilterAssetText(IAssetTextFilterRequestV2 request)
	{
		AssetTextFilterRequest assetTextFilterRequest = new AssetTextFilterRequest(new TextAuthor(request.ClientTextAuthor.Id, request.ClientTextAuthor.Name, request.ClientTextAuthor.IsUnder13), request.Name, request.Description, request.AssetType);
		return FilterAssetText(assetTextFilterRequest);
	}

	/// <summary>
	/// Filter the given name and description as if they were part of the same conversation by the same Author.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Platform.Assets.IAssetTextFilterRequest" /> that wraps the request.</param>
	/// <returns>a <see cref="T:Roblox.Platform.Assets.IAssetTextFilterResult" /> containing the filtered name and description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">In the case of bad input data</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">In the case where the filtering service is simply unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Assets.PlatformAssetTextFullyModeratedException">In the case where the text is fully moderated.</exception>
	public IAssetTextFilterResult FilterAssetText(IAssetTextFilterRequest request)
	{
		ValidateRequest(request);
		ValidateObjectName(request);
		if (!_Settings.AssetCreationNoContextEnabled)
		{
			return FilterTextWithContext(request);
		}
		return FilterTextNoContext(request);
	}

	private static void ValidateRequest(IAssetTextFilterRequest request)
	{
		if (request == null)
		{
			throw new PlatformArgumentNullException("request");
		}
		if (request.TextAuthor == null)
		{
			throw new PlatformArgumentNullException("Request has no Author");
		}
	}

	private void ValidateObjectName(IAssetTextFilterRequest request)
	{
		if (!_TextFilter.ValidateObjectName(new ObjectNameValidationRequest(request.Name)).IsValid)
		{
			throw new PlatformAssetTextFullyModeratedException("Asset Name is fully moderated.");
		}
	}

	private IAssetTextFilterResult FilterTextWithContext(IAssetTextFilterRequest request)
	{
		string room = Guid.NewGuid().ToString();
		ModeratedTextRequest nameRequest = new ModeratedTextRequest(request.TextAuthor, request.Name, TextFilterServerType.WebAsset, room);
		ModeratedTextRequest descriptionRequest = new ModeratedTextRequest(request.TextAuthor, request.Description, nameRequest.Server, nameRequest.Room);
		try
		{
			ITextFilterRuleResult nameFilteredResult = _TextFilter.FilterText(nameRequest);
			if (IsAssetWithFullyModeratedTextBlocked && nameFilteredResult.ModerationLevel == ModerationLevel.FullyModerated)
			{
				throw new PlatformAssetTextFullyModeratedException("Asset Name is fully moderated.");
			}
			ITextFilterRuleResult descriptionFilteredResult = _TextFilter.FilterText(descriptionRequest);
			if (IsAssetWithFullyModeratedTextBlocked && descriptionFilteredResult.ModerationLevel == ModerationLevel.FullyModerated)
			{
				throw new PlatformAssetTextFullyModeratedException("Asset Description is fully moderated.");
			}
			return new AssetTextFilterResult(nameFilteredResult.FilteredText, descriptionFilteredResult.FilteredText);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
	}

	private IAssetTextFilterResult FilterTextNoContext(IAssetTextFilterRequest request)
	{
		string room = Guid.NewGuid().ToString();
		FilterNameNoContext(request, room, out var redactedName, out var redactedNameLevel);
		if (string.IsNullOrWhiteSpace(request.Description))
		{
			return new AssetTextFilterResult(redactedName, "");
		}
		return FilterDescriptionAndCombinedNoContext(request, room, redactedName, redactedNameLevel);
	}

	private void FilterNameNoContext(IAssetTextFilterRequest request, string room, out string redactedName, out ModerationLevel redactedNameLevel)
	{
		ModeratedTextRequest nameRequest = new ModeratedTextRequest(request.TextAuthor, request.Name, TextFilterServerType.WebAsset, room);
		ITextFilterRuleResult nameResult;
		try
		{
			nameResult = _TextFilter.FilterTextNoContext(nameRequest);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
		redactedName = nameResult.FilteredText;
		redactedNameLevel = _TextFilter.GetModerationLevelOfFilteredText(request.Name, redactedName);
		if (IsAssetWithFullyModeratedTextBlocked && redactedNameLevel == ModerationLevel.FullyModerated)
		{
			throw new PlatformAssetTextFullyModeratedException("Asset Name is fully moderated.");
		}
	}

	private IAssetTextFilterResult FilterDescriptionAndCombinedNoContext(IAssetTextFilterRequest request, string room, string redactedName, ModerationLevel redactedNameLevel)
	{
		ModeratedTextRequest descriptionRequest = new ModeratedTextRequest(request.TextAuthor, request.Description, TextFilterServerType.WebAsset, room);
		ModeratedTextRequest combinedRequest = new ModeratedTextRequest(request.TextAuthor, CombineStrings(request.Name, request.Description), TextFilterServerType.WebAsset, room);
		ITextFilterRuleResult descriptionResult;
		ITextFilterRuleResult combinedResult;
		try
		{
			descriptionResult = _TextFilter.FilterTextNoContext(descriptionRequest);
			combinedResult = _TextFilter.FilterTextNoContext(combinedRequest);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("failted to filter the given description", ex);
		}
		string redactedDescription = descriptionResult.FilteredText;
		ModerationLevel redactedDescriptionLevel = _TextFilter.GetModerationLevelOfFilteredText(request.Description, redactedDescription);
		if (IsAssetWithFullyModeratedTextBlocked && redactedDescriptionLevel == ModerationLevel.FullyModerated)
		{
			throw new PlatformAssetTextFullyModeratedException("Asset Description is fully moderated.");
		}
		string redactedCombined = combinedResult.FilteredText;
		ModerationLevel redactedCombinedLevel = _TextFilter.GetModerationLevelOfFilteredText(combinedRequest.Text, redactedCombined);
		if (redactedNameLevel == ModerationLevel.FullyAcceptable && redactedDescriptionLevel == ModerationLevel.FullyAcceptable && redactedCombinedLevel == ModerationLevel.FullyAcceptable)
		{
			return new AssetTextFilterResult(redactedName, redactedDescription);
		}
		if (combinedResult.FilteredText.Contains(redactedName) && combinedResult.FilteredText.Contains(redactedDescription))
		{
			return new AssetTextFilterResult(redactedName, redactedDescription);
		}
		throw new PlatformAssetTextFullyModeratedException("Asset Name & Description is fully moderated.");
	}

	private string CombineStrings(string originalName, string originalDescription)
	{
		return originalName + "\n" + originalDescription;
	}
}
