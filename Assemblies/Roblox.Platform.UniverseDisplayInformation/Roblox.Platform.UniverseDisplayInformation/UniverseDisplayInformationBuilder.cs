using System;
using Roblox.ApiClientBase;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.EventStream;
using Roblox.Platform.GameLocalization;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.Platform.TranslationStorage;
using Roblox.Platform.UniverseDisplayInformation.Properties;
using Roblox.Platform.Universes;
using Roblox.TextFilter;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <inheritdoc />
public class UniverseDisplayInformationBuilder : IUniverseDisplayInformationBuilder
{
	private const string _DeleteNonExistingTranslationStatusDescription = "Cannot delete a non existing translation.";

	private const string _TextFilterClientV2Usage = "UniverseDisplayInformation";

	private readonly ITranslationStorageAccessor _TranslationStorageAccessor;

	private readonly ITranslationStorageBuilder _TranslationStorageBuilder;

	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly IChangeAgentFactory _ChangeAgentFactory;

	private readonly IGameLocalizationSettingsAuthority _GameLocalizationSettingsAuthority;

	private readonly IUniverseDisplayInformationBuilderSettings _Settings;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly IUniverseDisplayInformationChangeReporter _UniverseDisplayInformationChangeReporter;

	private readonly IGameNameDescriptionChangeEventStreamer _GameNameDescriptionChangeEventStreamer;

	private readonly ILogger _Logger;

	private readonly Func<IUniverse, string> _UniverseNameGetter;

	private readonly Func<IUniverse, string> _UniverseDescriptionGetter;

	private readonly Action<IUniverse, string, ITextAuthor, IClientTextAuthor, bool> _UniverseNameSetter;

	private readonly Action<IUniverse, string, ITextAuthor, IClientTextAuthor, bool> _UniverseDescriptionSetter;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="translationStorageAccessor">The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" />.</param>
	/// <param name="translationStorageBuilder">The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" />.</param>
	/// <param name="textFilterClientV2">The <see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" />.</param>
	/// <param name="changeAgentFactory">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />.</param>
	/// <param name="gameLocalizationSettingsAuthority">The <see cref="T:Roblox.Platform.GameLocalization.IGameLocalizationSettingsAuthority" />.</param>
	/// <param name="coreLocalizationAccessor">The <see cref="T:Roblox.Platform.Localization.Core.ICoreLocalizationAccessor" />.</param>
	/// <param name="eventStreamer">The <see cref="T:Roblox.Platform.EventStream.IEventStreamer" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	public UniverseDisplayInformationBuilder(ITranslationStorageAccessor translationStorageAccessor, ITranslationStorageBuilder translationStorageBuilder, ITextFilterClientV2 textFilterClientV2, IChangeAgentFactory changeAgentFactory, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ICoreLocalizationAccessor coreLocalizationAccessor, IEventStreamer eventStreamer, ILogger logger, ICounterRegistry counterRegistry)
		: this(translationStorageAccessor, translationStorageBuilder, textFilterClientV2, changeAgentFactory, gameLocalizationSettingsAuthority, coreLocalizationAccessor, new UniverseDisplayInformationChangeEventsPublisher(logger, counterRegistry), new UniverseDisplayInformationChangeReporter(), new GameNameDescriptionChangeEventStreamer(eventStreamer, logger), Settings.Default, logger)
	{
	}

	internal UniverseDisplayInformationBuilder(ITranslationStorageAccessor translationStorageAccessor, ITranslationStorageBuilder translationStorageBuilder, ITextFilterClientV2 textFilterClientV2, IChangeAgentFactory changeAgentFactory, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ICoreLocalizationAccessor coreLocalizationAccessor, IUniverseDisplayInformationChangeEventsPublisher universeDisplayInformationChangeEventsPublisher, IUniverseDisplayInformationChangeReporter universeDisplayInformationChangeReporter, IGameNameDescriptionChangeEventStreamer gameNameDescriptionChangeEventStreamer, IUniverseDisplayInformationBuilderSettings settings, ILogger logger)
	{
		_TranslationStorageAccessor = translationStorageAccessor ?? throw new PlatformArgumentNullException("translationStorageAccessor");
		_TranslationStorageBuilder = translationStorageBuilder ?? throw new PlatformArgumentNullException("translationStorageBuilder");
		_TextFilterClientV2 = textFilterClientV2 ?? throw new PlatformArgumentNullException("textFilterClientV2");
		_ChangeAgentFactory = changeAgentFactory ?? throw new PlatformArgumentNullException("changeAgentFactory");
		_GameLocalizationSettingsAuthority = gameLocalizationSettingsAuthority ?? throw new PlatformArgumentNullException("gameLocalizationSettingsAuthority");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_UniverseDisplayInformationChangeReporter = universeDisplayInformationChangeReporter ?? throw new PlatformArgumentNullException("universeDisplayInformationChangeReporter");
		_GameNameDescriptionChangeEventStreamer = gameNameDescriptionChangeEventStreamer ?? throw new PlatformArgumentNullException("gameNameDescriptionChangeEventStreamer");
		if (universeDisplayInformationChangeEventsPublisher == null)
		{
			throw new PlatformArgumentNullException("universeDisplayInformationChangeEventsPublisher");
		}
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		universeDisplayInformationChangeEventsPublisher.Subscribe(_UniverseDisplayInformationChangeReporter);
		_UniverseNameGetter = (IUniverse universe) => universe.Name;
		_UniverseDescriptionGetter = (IUniverse universe) => universe.Description;
		_UniverseNameSetter = delegate(IUniverse universe, string name, ITextAuthor textAuthor, IClientTextAuthor clientTextAuthor, bool allowPartiallyModerated)
		{
			universe.UpdateNameDescription(name, universe.Description, clientTextAuthor, allowPartiallyModerated);
		};
		_UniverseDescriptionSetter = delegate(IUniverse universe, string description, ITextAuthor textAuthor, IClientTextAuthor clientTextAuthor, bool allowPartiallyModerated)
		{
			universe.UpdateNameDescription(universe.Name, description, clientTextAuthor, allowPartiallyModerated);
		};
	}

	/// <inheritdoc />
	public void SetDisplayName(IUniverse universe, ILanguageFamily language, string newName, IUser user, bool allowPartiallyModerated, out string nameSaved)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (string.IsNullOrWhiteSpace(newName))
		{
			if (!_Settings.IsAllowingNullOrWhitespaceNameEnabled)
			{
				throw new PlatformArgumentException(string.Format("{0} should not be null or whitespaces", "newName"));
			}
			newName = string.Empty;
		}
		if (newName.Length > _Settings.UniverseNameMaxLength)
		{
			throw new PlatformArgumentException(string.Format("{0} should not be longer than {1}", "newName", _Settings.UniverseNameMaxLength));
		}
		nameSaved = DoSetDisplayInformation(universe, language, newName, user, ContentSourceType.UniverseDisplayNames, _UniverseNameGetter, _UniverseNameSetter, allowPartiallyModerated, out var isSourceLanguage, out var actionType);
		UniverseDisplayInformationActionType universeDisplayInformationActionType = ((actionType != GameNameDescriptionChangeEventActionTypeEnum.Deleted) ? UniverseDisplayInformationActionType.Updated : UniverseDisplayInformationActionType.Deleted);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.Name, universeDisplayInformationActionType);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum.User, actionType, GameNameDescriptionChangeEventFieldEnum.Name);
	}

	/// <inheritdoc />
	public void SetDisplayNameTrusted(IUniverse universe, ILanguageFamily language, string trustedName, IUser user)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (string.IsNullOrWhiteSpace(trustedName))
		{
			if (!_Settings.IsAllowingNullOrWhitespaceNameEnabled)
			{
				throw new PlatformArgumentException(string.Format("{0} should not be null or whitespaces", "trustedName"));
			}
			trustedName = string.Empty;
		}
		if (trustedName.Length > _Settings.UniverseNameMaxLength)
		{
			throw new PlatformArgumentException(string.Format("{0} should not be longer than {1}", "trustedName", _Settings.UniverseNameMaxLength));
		}
		bool isSourceLanguage;
		GameNameDescriptionChangeEventActionTypeEnum actionType;
		if (ShouldSetToUniverseDatabase(universe, language))
		{
			isSourceLanguage = true;
			actionType = GameNameDescriptionChangeEventActionTypeEnum.Updated;
			universe.UpdateNameDescriptionTrusted(trustedName, universe.Description);
		}
		else
		{
			if (!_Settings.IsModifyingOrDeletingTranslationsEnabled)
			{
				throw new FeatureDisabledException("Setting display information in non-source language is disabled.");
			}
			isSourceLanguage = false;
			if (string.IsNullOrWhiteSpace(trustedName))
			{
				actionType = GameNameDescriptionChangeEventActionTypeEnum.Deleted;
				DeleteTranslation(universe, language, ContentSourceType.UniverseDisplayNames, user);
			}
			else
			{
				actionType = GetActionTypeForTranslationCreationOrDeletion(universe, language, ContentSourceType.UniverseDisplayNames);
				_TranslationStorageBuilder.CreateOrUpdateTranslation(language, ContentSourceType.UniverseDisplayNames, ContentVariantType.Production, universe.Id.ToString(), trustedName, isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(user));
			}
		}
		UniverseDisplayInformationActionType universeDisplayInformationActionType = ((actionType != GameNameDescriptionChangeEventActionTypeEnum.Deleted) ? UniverseDisplayInformationActionType.Updated : UniverseDisplayInformationActionType.Deleted);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.Name, universeDisplayInformationActionType);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum.Other, actionType, GameNameDescriptionChangeEventFieldEnum.Name);
	}

	/// <inheritdoc />
	public void SetDisplayDescription(IUniverse universe, ILanguageFamily language, string newDescription, IUser user, bool allowPartiallyModerated, out string descriptionSaved)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		newDescription = (string.IsNullOrWhiteSpace(newDescription) ? string.Empty : newDescription);
		if (newDescription.Length > _Settings.UniverseDescriptionMaxLength)
		{
			throw new PlatformArgumentException(string.Format("{0} should not be longer than {1}", "newDescription", _Settings.UniverseDescriptionMaxLength));
		}
		descriptionSaved = DoSetDisplayInformation(universe, language, newDescription, user, ContentSourceType.UniverseDisplayDescriptions, _UniverseDescriptionGetter, _UniverseDescriptionSetter, allowPartiallyModerated, out var isSourceLanguage, out var actionType);
		UniverseDisplayInformationActionType universeDisplayInformationActionType = ((actionType != GameNameDescriptionChangeEventActionTypeEnum.Deleted) ? UniverseDisplayInformationActionType.Updated : UniverseDisplayInformationActionType.Deleted);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.Description, universeDisplayInformationActionType);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum.User, actionType, GameNameDescriptionChangeEventFieldEnum.Description);
	}

	/// <inheritdoc />
	public void SetDisplayDescriptionTrusted(IUniverse universe, ILanguageFamily language, string trustedDescription, IUser user)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		trustedDescription = (string.IsNullOrWhiteSpace(trustedDescription) ? string.Empty : trustedDescription);
		if (trustedDescription.Length > _Settings.UniverseDescriptionMaxLength)
		{
			throw new PlatformArgumentException(string.Format("{0} should not be longer than {1}", "trustedDescription", _Settings.UniverseDescriptionMaxLength));
		}
		bool isSourceLanguage;
		GameNameDescriptionChangeEventActionTypeEnum actionType;
		if (ShouldSetToUniverseDatabase(universe, language))
		{
			isSourceLanguage = true;
			actionType = GameNameDescriptionChangeEventActionTypeEnum.Updated;
			universe.UpdateNameDescriptionTrusted(universe.Name, trustedDescription);
		}
		else
		{
			if (!_Settings.IsModifyingOrDeletingTranslationsEnabled)
			{
				throw new FeatureDisabledException("Setting display information in non-source language is disabled.");
			}
			isSourceLanguage = false;
			if (string.IsNullOrWhiteSpace(trustedDescription))
			{
				actionType = GameNameDescriptionChangeEventActionTypeEnum.Deleted;
				DeleteTranslation(universe, language, ContentSourceType.UniverseDisplayDescriptions, user);
			}
			else
			{
				actionType = GetActionTypeForTranslationCreationOrDeletion(universe, language, ContentSourceType.UniverseDisplayDescriptions);
				_TranslationStorageBuilder.CreateOrUpdateTranslation(language, ContentSourceType.UniverseDisplayDescriptions, ContentVariantType.Production, universe.Id.ToString(), trustedDescription, isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(user));
			}
		}
		UniverseDisplayInformationActionType universeDisplayInformationActionType = ((actionType != GameNameDescriptionChangeEventActionTypeEnum.Deleted) ? UniverseDisplayInformationActionType.Updated : UniverseDisplayInformationActionType.Deleted);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.Description, universeDisplayInformationActionType);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum.Other, actionType, GameNameDescriptionChangeEventFieldEnum.Description);
	}

	/// <inheritdoc />
	public void SetDisplayNameAndDescription(IUniverse universe, ILanguageFamily language, string newName, string newDescription, IUser user, bool allowPartiallyModerated, out string nameSaved, out string descriptionSaved)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (string.IsNullOrWhiteSpace(newName))
		{
			if (!_Settings.IsAllowingNullOrWhitespaceNameEnabled)
			{
				throw new PlatformArgumentException(string.Format("{0} should not be null or whitespaces", "newName"));
			}
			newName = string.Empty;
		}
		if (newName.Length > _Settings.UniverseNameMaxLength)
		{
			throw new PlatformArgumentException(string.Format("{0} should not be longer than {1}", "newName", _Settings.UniverseNameMaxLength));
		}
		newDescription = (string.IsNullOrWhiteSpace(newDescription) ? string.Empty : newDescription);
		if (newDescription.Length > _Settings.UniverseDescriptionMaxLength)
		{
			throw new PlatformArgumentException(string.Format("{0} should not be longer than {1}", "newDescription", _Settings.UniverseDescriptionMaxLength));
		}
		GetTextAuthorFromUser(user);
		IClientTextAuthor clientTextAuthor = GetClientTextAuthorFromUser(user);
		bool isSourceLanguage;
		GameNameDescriptionChangeEventActionTypeEnum actionTypeForName;
		GameNameDescriptionChangeEventActionTypeEnum actionTypeForDescription;
		if (ShouldSetToUniverseDatabase(universe, language))
		{
			isSourceLanguage = true;
			actionTypeForName = (actionTypeForDescription = GameNameDescriptionChangeEventActionTypeEnum.Updated);
			universe.UpdateNameDescription(newName, newDescription, clientTextAuthor, allowPartiallyModerated);
			nameSaved = universe.Name;
			descriptionSaved = universe.Description;
		}
		else
		{
			if (!_Settings.IsModifyingOrDeletingTranslationsEnabled)
			{
				throw new FeatureDisabledException("Setting display information in non-source language is disabled.");
			}
			isSourceLanguage = false;
			string filteredName = (string.IsNullOrWhiteSpace(newName) ? null : GetFilteredText(newName, clientTextAuthor, allowPartiallyModerated));
			string filteredDescription = (string.IsNullOrWhiteSpace(newDescription) ? null : GetFilteredText(newDescription, clientTextAuthor, allowPartiallyModerated));
			if (string.IsNullOrWhiteSpace(filteredName))
			{
				actionTypeForName = GameNameDescriptionChangeEventActionTypeEnum.Deleted;
				DeleteTranslation(universe, language, ContentSourceType.UniverseDisplayNames, user);
			}
			else
			{
				actionTypeForName = GetActionTypeForTranslationCreationOrDeletion(universe, language, ContentSourceType.UniverseDisplayNames);
				_TranslationStorageBuilder.CreateOrUpdateTranslation(language, ContentSourceType.UniverseDisplayNames, ContentVariantType.Production, universe.Id.ToString(), filteredName, isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(user));
			}
			if (string.IsNullOrWhiteSpace(filteredDescription))
			{
				actionTypeForDescription = GameNameDescriptionChangeEventActionTypeEnum.Deleted;
				DeleteTranslation(universe, language, ContentSourceType.UniverseDisplayDescriptions, user);
			}
			else
			{
				actionTypeForDescription = GetActionTypeForTranslationCreationOrDeletion(universe, language, ContentSourceType.UniverseDisplayDescriptions);
				_TranslationStorageBuilder.CreateOrUpdateTranslation(language, ContentSourceType.UniverseDisplayDescriptions, ContentVariantType.Production, universe.Id.ToString(), filteredDescription, isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(user));
			}
			nameSaved = filteredName;
			descriptionSaved = filteredDescription;
		}
		UniverseDisplayInformationActionType universeDisplayInformationActionType = ((actionTypeForName != GameNameDescriptionChangeEventActionTypeEnum.Deleted || actionTypeForDescription != GameNameDescriptionChangeEventActionTypeEnum.Deleted) ? UniverseDisplayInformationActionType.Updated : UniverseDisplayInformationActionType.Deleted);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.NameAndDescription, universeDisplayInformationActionType);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum.User, actionTypeForName, GameNameDescriptionChangeEventFieldEnum.Name);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage, GameNameDescriptionChangeEventUserTypeEnum.User, actionTypeForDescription, GameNameDescriptionChangeEventFieldEnum.Description);
	}

	/// <inheritdoc />
	public void DeleteDisplayName(IUniverse universe, ILanguageFamily language, IUser user)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (language == null)
		{
			throw new PlatformArgumentNullException("language");
		}
		DoDeleteDisplayInformation(universe, language, ContentSourceType.UniverseDisplayNames, user);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.Name, UniverseDisplayInformationActionType.Deleted);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage: false, GameNameDescriptionChangeEventUserTypeEnum.User, GameNameDescriptionChangeEventActionTypeEnum.Deleted, GameNameDescriptionChangeEventFieldEnum.Name);
	}

	/// <inheritdoc />
	public void DeleteDisplayDescription(IUniverse universe, ILanguageFamily language, IUser user)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (language == null)
		{
			throw new PlatformArgumentNullException("language");
		}
		DoDeleteDisplayInformation(universe, language, ContentSourceType.UniverseDisplayDescriptions, user);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.Description, UniverseDisplayInformationActionType.Deleted);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage: false, GameNameDescriptionChangeEventUserTypeEnum.User, GameNameDescriptionChangeEventActionTypeEnum.Deleted, GameNameDescriptionChangeEventFieldEnum.Description);
	}

	/// <inheritdoc />
	public void DeleteDisplayNameAndDescription(IUniverse universe, ILanguageFamily language, IUser user)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (language == null)
		{
			throw new PlatformArgumentNullException("language");
		}
		ILanguageFamily sourceLanguage = _GameLocalizationSettingsAuthority.GetSourceLanguageFamily(universe);
		if (AreLanguagesNotNullAndSame(language, sourceLanguage))
		{
			throw new PlatformInvalidOperationException("Deleting universe display information for source language is not allowed.");
		}
		if (!_Settings.IsModifyingOrDeletingTranslationsEnabled)
		{
			throw new FeatureDisabledException("Deleting display information in non-source language is disabled.");
		}
		DeleteTranslation(universe, language, ContentSourceType.UniverseDisplayDescriptions, user);
		DeleteTranslation(universe, language, ContentSourceType.UniverseDisplayNames, user);
		_UniverseDisplayInformationChangeReporter.DisplayInformationChanged(universe.Id, language, UniverseDisplayInformationChangeType.NameAndDescription, UniverseDisplayInformationActionType.Deleted);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage: false, GameNameDescriptionChangeEventUserTypeEnum.User, GameNameDescriptionChangeEventActionTypeEnum.Deleted, GameNameDescriptionChangeEventFieldEnum.Name);
		_GameNameDescriptionChangeEventStreamer.StreamGameNameDescriptionChangeEvent(user, universe, language, isSourceLanguage: false, GameNameDescriptionChangeEventUserTypeEnum.User, GameNameDescriptionChangeEventActionTypeEnum.Deleted, GameNameDescriptionChangeEventFieldEnum.Description);
	}

	internal virtual IChangeAgent SafeGetChangeAgentFromUser(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		return _ChangeAgentFactory.GetChangeAgentForUser(user);
	}

	private string DoSetDisplayInformation(IUniverse universe, ILanguageFamily language, string valueToSet, IUser user, ContentSourceType contentSourceType, Func<IUniverse, string> propertyGetter, Action<IUniverse, string, ITextAuthor, IClientTextAuthor, bool> nameDescriptionSetter, bool allowPartiallyModerated, out bool isSourceLanguage, out GameNameDescriptionChangeEventActionTypeEnum actionType)
	{
		ITextAuthor textAuthor = GetTextAuthorFromUser(user);
		IClientTextAuthor clientTextAuthor = GetClientTextAuthorFromUser(user);
		if (ShouldSetToUniverseDatabase(universe, language))
		{
			nameDescriptionSetter(universe, valueToSet, textAuthor, clientTextAuthor, allowPartiallyModerated);
			isSourceLanguage = true;
			actionType = GameNameDescriptionChangeEventActionTypeEnum.Updated;
			return propertyGetter(universe);
		}
		if (!_Settings.IsModifyingOrDeletingTranslationsEnabled)
		{
			throw new FeatureDisabledException("Setting display information in non-source language is disabled.");
		}
		isSourceLanguage = false;
		if (string.IsNullOrWhiteSpace(valueToSet))
		{
			actionType = GameNameDescriptionChangeEventActionTypeEnum.Deleted;
			DeleteTranslation(universe, language, contentSourceType, user);
			return null;
		}
		string filteredText = GetFilteredText(valueToSet, clientTextAuthor, allowPartiallyModerated);
		actionType = GetActionTypeForTranslationCreationOrDeletion(universe, language, contentSourceType);
		_TranslationStorageBuilder.CreateOrUpdateTranslation(language, contentSourceType, ContentVariantType.Production, universe.Id.ToString(), filteredText, isSourceContentVariantAndLocale: false, SafeGetChangeAgentFromUser(user));
		return filteredText;
	}

	private void DoDeleteDisplayInformation(IUniverse universe, ILanguageFamily language, ContentSourceType contentSourceType, IUser user)
	{
		ILanguageFamily sourceLanguage = _GameLocalizationSettingsAuthority.GetSourceLanguageFamily(universe);
		if (AreLanguagesNotNullAndSame(language, sourceLanguage))
		{
			throw new PlatformInvalidOperationException("Deleting universe display information for source language is not allowed.");
		}
		if (!_Settings.IsModifyingOrDeletingTranslationsEnabled)
		{
			throw new FeatureDisabledException("Deleting display information in non-source language is disabled.");
		}
		DeleteTranslation(universe, language, contentSourceType, user);
	}

	private bool AreLanguagesNotNullAndSame(ILanguageFamily languageA, ILanguageFamily languageB)
	{
		if (languageA != null && languageB != null)
		{
			return languageA.Id == languageB.Id;
		}
		return false;
	}

	private bool ShouldSetToUniverseDatabase(IUniverse universe, ILanguageFamily language)
	{
		if (language == null)
		{
			return true;
		}
		ILanguageFamily sourceLanguage = _GameLocalizationSettingsAuthority.GetSourceLanguageFamily(universe);
		return AreLanguagesNotNullAndSame(language, sourceLanguage);
	}

	private void DeleteTranslation(IUniverse universe, ILanguageFamily language, ContentSourceType contentSourceType, IUser user)
	{
		try
		{
			_TranslationStorageBuilder.DeleteTranslation(language, contentSourceType, ContentVariantType.Production, universe.Id.ToString(), SafeGetChangeAgentFromUser(user));
		}
		catch (PlatformOperationUnavailableException ex) when (ex.InnerException is ApiClientException)
		{
			if (((ApiClientException)ex.InnerException).StatusDescription != "Cannot delete a non existing translation.")
			{
				throw;
			}
		}
	}

	internal virtual string GetFilteredText(string text, IClientTextAuthor clientTextAuthor, bool allowPartiallyModerated)
	{
		FilterTextResult result;
		try
		{
			result = _TextFilterClientV2.FilterText(text, clientTextAuthor, "UniverseDisplayInformation", "", false);
		}
		catch (Exception ex)
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
		if (result.ModerationLevel == 3)
		{
			throw new PlatformUniverseTextFullyModeratedException("Universe display information is fully moderated.");
		}
		if (!allowPartiallyModerated && result.ModerationLevel == 2)
		{
			throw new UniverseTextPartiallyModeratedException("Universe display information is partially moderated.");
		}
		return result.FilteredText;
	}

	private GameNameDescriptionChangeEventActionTypeEnum GetActionTypeForTranslationCreationOrDeletion(IUniverse universe, ILanguageFamily languageFamily, ContentSourceType contentSourceType)
	{
		if (_TranslationStorageAccessor.GetTranslation(languageFamily, contentSourceType, ContentVariantType.Production, universe.Id.ToString()) == null)
		{
			return GameNameDescriptionChangeEventActionTypeEnum.Created;
		}
		return GameNameDescriptionChangeEventActionTypeEnum.Updated;
	}

	internal virtual ITextAuthor GetTextAuthorFromUser(IUser user)
	{
		return user.ToTextAuthor();
	}

	internal virtual IClientTextAuthor GetClientTextAuthorFromUser(IUser user)
	{
		return user.ToClientTextAuthor();
	}
}
