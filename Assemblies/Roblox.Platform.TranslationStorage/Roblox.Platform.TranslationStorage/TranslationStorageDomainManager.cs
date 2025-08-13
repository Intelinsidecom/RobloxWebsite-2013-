using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// A domain manager for creating the accessors and builders.
/// </summary>
public class TranslationStorageDomainManager
{
	private readonly ITranslationStorageClient _Client;

	private readonly ILogger _Logger;

	private readonly ITranslationStorageResponseConverter _TranslationStorageResponseConverter;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TranslationStorage.TranslationStorageDomainManager" /> class.
	/// </summary>
	/// <param name="client">The client.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">client</exception>
	public TranslationStorageDomainManager(ITranslationStorageClient client, ILogger logger)
	{
		_Client = client ?? throw new PlatformArgumentNullException("client");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_TranslationStorageResponseConverter = new TranslationStorageResponseConverter();
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" />.
	/// </summary>
	/// <returns>A new <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" />.</returns>
	public ITranslationStorageAccessor GetTranslationStorageAccessor()
	{
		return new TranslationStorageAccessor(_Client, _Logger);
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageBuilder" />.
	/// </summary>
	/// <returns>
	/// A new <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageBuilder" />.
	/// </returns>
	public ITranslationStorageBuilder GetTranslationStorageBuilder()
	{
		return new TranslationStorageBuilder(_Client, _TranslationStorageResponseConverter, _Logger);
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />.
	/// </summary>
	/// <returns>
	/// A new <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />.
	/// </returns>
	public IChangeAgentFactory GetChangeAgentFactory()
	{
		return new ChangeAgentFactory(_Client);
	}

	/// <summary>
	/// Gets the generic translation storage accessor.
	/// </summary>
	/// <typeparam name="TIdentifier">The type of the identifier.</typeparam>
	/// <returns>An <see cref="T:Roblox.Platform.TranslationStorage.IGenericTranslationStorageAccessor`1" /></returns>
	public IGenericTranslationStorageAccessor<TIdentifier> GetGenericTranslationStorageAccessor<TIdentifier>(Func<bool> isAccessingTranslationsEnabledGetter, Func<bool> isReturningTranslationsEnabledGetter, Func<int> shadowRolloutPercentageGetter)
	{
		if (isAccessingTranslationsEnabledGetter == null)
		{
			throw new PlatformArgumentNullException("isAccessingTranslationsEnabledGetter");
		}
		if (isReturningTranslationsEnabledGetter == null)
		{
			throw new PlatformArgumentNullException("isReturningTranslationsEnabledGetter");
		}
		if (shadowRolloutPercentageGetter == null)
		{
			throw new PlatformArgumentNullException("shadowRolloutPercentageGetter");
		}
		return new GenericTranslationStorageAccessor<TIdentifier>(_Client, _Logger, isAccessingTranslationsEnabledGetter, isReturningTranslationsEnabledGetter, shadowRolloutPercentageGetter);
	}
}
