using System.Linq;
using Roblox.Platform.AccountPins.Interfaces;
using Roblox.Platform.AccountPins.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins.Implementation;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.AccountPins.Interfaces.IAccountPinFormatValidator" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.Interfaces.IAccountPinFormatValidator" />
internal class AccountPinFormatValidator : IAccountPinFormatValidator
{
	internal virtual int _PinLength => Settings.Default.AccountPinLength;

	internal virtual string _PinCharacters => Settings.Default.AccountPinCharacters;

	internal AccountPinsDomainFactories _DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.Implementation.AccountPinFormatValidator" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	public AccountPinFormatValidator(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public bool ValidatePin(string pin)
	{
		if (string.IsNullOrWhiteSpace(pin))
		{
			throw new PlatformArgumentException("pin");
		}
		if (pin.Length == _PinLength)
		{
			return pin.All((char character) => _PinCharacters.Contains(character));
		}
		return false;
	}
}
