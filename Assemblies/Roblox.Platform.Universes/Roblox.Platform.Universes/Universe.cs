using System;
using Roblox.Platform.Universes.Events;
using Roblox.Platform.Universes.Properties;
using Roblox.TextFilter.Client;
using Roblox.Universes.Client;

namespace Roblox.Platform.Universes;

internal class Universe : IUniverse
{
	private readonly UniverseDomainFactories _UniverseDomainFactories;

	private readonly ISettings _Settings;

	internal virtual IUniversesClient UniversesClient => _UniverseDomainFactories.UniversesClient;

	public long Id { get; }

	public string Name { get; private set; }

	public string Description { get; private set; }

	public bool IsArchived { get; set; }

	public long? RootPlaceId { get; private set; }

	public string CreatorType { get; }

	public long CreatorTargetId { get; }

	public string PrivacyType { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	public virtual bool StudioAccessToApisAllowed { get; internal set; }

	public Universe(Universe clientUniverse, UniverseDomainFactories universeDomainFactories)
		: this(clientUniverse, universeDomainFactories, Settings.Default)
	{
	}

	public Universe(Universe clientUniverse, UniverseDomainFactories universeDomainFactories, ISettings settings)
	{
		_UniverseDomainFactories = universeDomainFactories ?? throw new ArgumentNullException("universeDomainFactories");
		if (clientUniverse == null)
		{
			throw new ArgumentNullException("clientUniverse");
		}
		Id = clientUniverse.Id;
		_Settings = settings ?? throw new ArgumentNullException("settings");
		Name = clientUniverse.Name;
		Description = clientUniverse.Description;
		IsArchived = clientUniverse.IsArchived;
		RootPlaceId = ((clientUniverse.RootPlaceId == 0) ? null : clientUniverse.RootPlaceId);
		CreatorType = clientUniverse.CreatorType;
		CreatorTargetId = clientUniverse.CreatorTargetId;
		Created = clientUniverse.Created;
		Updated = clientUniverse.Updated;
		PrivacyType = clientUniverse.PrivacyType;
		StudioAccessToApisAllowed = clientUniverse.StudioAccessToApisAllowed;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniverse.UpdateNameDescription(System.String,System.String,Roblox.TextFilter.Client.IClientTextAuthor,System.Boolean)" />
	public void UpdateNameDescription(string newName, string newDescription, IClientTextAuthor clientTextAuthor, bool allowPartiallyModerated = true)
	{
		if (string.IsNullOrWhiteSpace(newName) || newName.Length > Settings.Default.UniverseNameMaxLength)
		{
			throw new ArgumentException("newName");
		}
		if (clientTextAuthor == null)
		{
			throw new ArgumentNullException("clientTextAuthor");
		}
		UniverseTextFilterRequest textFilterRequest = new UniverseTextFilterRequest
		{
			ClientTextAuthor = clientTextAuthor,
			Name = newName,
			Description = newDescription,
			AllowPartiallyModerated = allowPartiallyModerated
		};
		IUniverseTextFilterResult textFilterResult = _UniverseDomainFactories.UniverseTextFilter.FilterUniverseText(textFilterRequest);
		UniversesClient.UpdateUniverse(Id, textFilterResult.Name, textFilterResult.Description, RootPlaceId, StudioAccessToApisAllowed, IsArchived, (PrivacyType?)null);
		_UniverseDomainFactories.UniverseChangeReporter.EntityChanged(Id, UniverseChangeType.NameDescription);
		Name = textFilterResult.Name;
		Description = textFilterResult.Description;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniverse.UpdateNameDescriptionTrusted(System.String,System.String)" />
	public void UpdateNameDescriptionTrusted(string trustedName, string trustedDescription)
	{
		if (string.IsNullOrWhiteSpace(trustedName) || trustedName.Length > Settings.Default.UniverseNameMaxLength)
		{
			throw new ArgumentException("trustedName");
		}
		UniversesClient.UpdateUniverse(Id, trustedName, trustedDescription, RootPlaceId, StudioAccessToApisAllowed, IsArchived, (PrivacyType?)null);
		_UniverseDomainFactories.UniverseChangeReporter.EntityChanged(Id, UniverseChangeType.NameDescription);
		Name = trustedName;
		Description = trustedDescription;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniverse.UpdateBasicSettings(System.Nullable{System.Boolean})" />
	public void UpdateBasicSettings(bool? newStudioAccessToApisAllowed)
	{
		UniversesClient.UpdateUniverse(Id, Name, Description, RootPlaceId, newStudioAccessToApisAllowed ?? StudioAccessToApisAllowed, IsArchived, (PrivacyType?)null);
		if (newStudioAccessToApisAllowed.HasValue)
		{
			StudioAccessToApisAllowed = newStudioAccessToApisAllowed.Value;
		}
	}
}
