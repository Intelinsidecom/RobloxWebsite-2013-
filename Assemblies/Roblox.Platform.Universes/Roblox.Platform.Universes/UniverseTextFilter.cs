using System;
using Roblox.Platform.Core;
using Roblox.Platform.Universes.Properties;
using Roblox.TextFilter.Client;
using Roblox.TextFilter.Client.Models.Common;

namespace Roblox.Platform.Universes;

/// <inheritdoc cref="T:Roblox.Platform.Universes.IUniverseTextFilter" />
internal class UniverseTextFilter : IUniverseTextFilter
{
	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly ISettings _Settings;

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.Universes.UniverseTextFilter" />
	/// </summary>
	/// <param name="textFilterClientV2">A <see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="textFilterClient" />
	/// - <paramref name="textFilterClientV2" />
	/// </exception>
	public UniverseTextFilter(ITextFilterClientV2 textFilterClientV2)
		: this(textFilterClientV2, Settings.Default)
	{
	}

	public UniverseTextFilter(ITextFilterClientV2 textFilterClientV2, ISettings settings)
	{
		_TextFilterClientV2 = textFilterClientV2 ?? throw new ArgumentNullException("textFilterClientV2");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniverseTextFilter.FilterUniverseText(Roblox.Platform.Universes.IUniverseTextFilterRequest)" />
	public IUniverseTextFilterResult FilterUniverseText(IUniverseTextFilterRequest request)
	{
		ValidateRequest(request);
		try
		{
			FilterTextResult nameFilteredResult = _TextFilterClientV2.FilterObjectName(request.Name, request.ClientTextAuthor, TextFilterServerType.WebUniverse, "", true);
			if (nameFilteredResult.ModerationLevel == 3)
			{
				throw new PlatformUniverseTextFullyModeratedException("Universe Name is fully moderated.");
			}
			if (!request.AllowPartiallyModerated && nameFilteredResult.ModerationLevel == 2)
			{
				throw new UniverseTextPartiallyModeratedException("Universe Name is partially moderated.");
			}
			if (string.IsNullOrWhiteSpace(request.Description))
			{
				return new UniverseTextFilterResult
				{
					Name = nameFilteredResult.FilteredText,
					Description = (request.Description ?? "")
				};
			}
			FilterTextResult descriptionFilteredResult = _TextFilterClientV2.FilterText(request.Description, request.ClientTextAuthor, TextFilterServerType.WebUniverse, "", true);
			if (descriptionFilteredResult.ModerationLevel == 3)
			{
				throw new PlatformUniverseTextFullyModeratedException("Universe Description is fully moderated.");
			}
			if (!request.AllowPartiallyModerated && descriptionFilteredResult.ModerationLevel == 2)
			{
				throw new UniverseTextPartiallyModeratedException("Universe Description is partially moderated.");
			}
			FilterTextResult combinedFilteredResult = _TextFilterClientV2.FilterText(request.Name + "\n" + request.Description, request.ClientTextAuthor, TextFilterServerType.WebUniverse, "", true);
			if (nameFilteredResult.ModerationLevel == 1 && descriptionFilteredResult.ModerationLevel == 1 && combinedFilteredResult.ModerationLevel == 1)
			{
				return new UniverseTextFilterResult
				{
					Name = nameFilteredResult.FilteredText,
					Description = descriptionFilteredResult.FilteredText
				};
			}
			if (!combinedFilteredResult.FilteredText.Contains(nameFilteredResult.FilteredText) || !combinedFilteredResult.FilteredText.Contains(descriptionFilteredResult.FilteredText))
			{
				throw new PlatformUniverseTextFullyModeratedException("Universe Name & Description are fully moderated.");
			}
			return new UniverseTextFilterResult
			{
				Name = nameFilteredResult.FilteredText,
				Description = descriptionFilteredResult.FilteredText
			};
		}
		catch (Exception ex) when (!(ex is PlatformUniverseTextFullyModeratedException) && !(ex is UniverseTextPartiallyModeratedException))
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
	}

	private void ValidateRequest(IUniverseTextFilterRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (request.ClientTextAuthor == null)
		{
			throw new ArgumentException("Request has no Author", "request");
		}
	}
}
