using System.Collections.Concurrent;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

/// <inheritdoc />
/// <summary>
/// An implementation of an <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.TranslationStorage.IChangeAgentFactory" />
internal class ChangeAgentFactory : IChangeAgentFactory
{
	private readonly ITranslationStorageClient _Client;

	private readonly IDictionary<AutomationType, int> _AutomationTypes;

	public ChangeAgentFactory(ITranslationStorageClient client)
	{
		_Client = client ?? throw new PlatformArgumentNullException("client");
		_AutomationTypes = new ConcurrentDictionary<AutomationType, int>();
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.IChangeAgentFactory.GetChangeAgentForUser(Roblox.Platform.Membership.IUser)" />
	public IChangeAgent GetChangeAgentForUser(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		return new ChangeAgent(ChangeAgentType.User, user.Id);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.IChangeAgentFactory.GetChangeAgentForAutomation(Roblox.Platform.TranslationStorage.AutomationType)" />
	public IChangeAgent GetChangeAgentForAutomation(AutomationType automationType)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		int targetId;
		if (_AutomationTypes.ContainsKey(automationType))
		{
			targetId = _AutomationTypes[automationType];
		}
		else
		{
			targetId = _Client.GetOrCreateAutomationType(new GetOrCreateAutomationTypeRequest
			{
				AutomationType = automationType.ToString()
			}).AutomationTypeId;
			_AutomationTypes.Add(automationType, targetId);
		}
		return new ChangeAgent(ChangeAgentType.Automation, targetId);
	}
}
