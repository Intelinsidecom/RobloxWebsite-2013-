using System.Collections.Generic;
using System.Linq;
using Roblox.Configuration;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat;

internal class DecoratorWhitelistValidator : IDecoratorWhitelistValidator
{
	private IReadOnlyCollection<string> _DecoratorsWhitelist;

	public DecoratorWhitelistValidator()
	{
		LoadAcceptedDecorators();
		Settings.Default.MonitorChanges((Settings s) => s.DecoratorsWhitelist, LoadAcceptedDecorators);
	}

	public bool IsDecoratorWhitelisted(string decorator)
	{
		return _DecoratorsWhitelist.Contains(decorator);
	}

	private void LoadAcceptedDecorators()
	{
		_DecoratorsWhitelist = (IReadOnlyCollection<string>)(object)Settings.Default.DecoratorsWhitelist.Split(',');
	}
}
