using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;

namespace Roblox.Platform.Demographics;

internal class PhoneNumber : PhoneNumberIdentifier, IPhoneNumber, IPhoneNumberIdentifier, IDomainObjectIdentifier<int>
{
	private readonly DemographicsDomainFactories _DomainFactories;

	private const char _ExitCodeForInternationalNumbersSymbol = '+';

	public IPhoneNumberInternationalPrefixIdentifier InternationalPrefixIdentifier { get; }

	public IPhoneNumberInternationalPrefix InternationalPrefix { get; }

	public string FullPhoneNumber { get; }

	public string NationalPhoneNumber { get; set; }

	public string Prefix { get; set; }

	public bool IsBlacklisted { get; private set; }

	public string Value => FullPhoneNumber;

	internal PhoneNumber(DemographicsDomainFactories domainFactories, IPhoneNumberEntity entity, IPhoneNumberInternationalPrefix prefix)
		: base(entity.Id)
	{
		_DomainFactories = domainFactories;
		if (prefix != null)
		{
			InternationalPrefixIdentifier = new PhoneNumberInternationalPrefixIdentifier(prefix.Id);
			if (!string.IsNullOrEmpty(entity.NationalPhoneNumber))
			{
				FullPhoneNumber = prefix.Value + entity.NationalPhoneNumber;
			}
			else
			{
				FullPhoneNumber = entity.Value;
			}
		}
		else
		{
			InternationalPrefixIdentifier = null;
			FullPhoneNumber = ((!string.IsNullOrEmpty(entity.NationalPhoneNumber)) ? entity.NationalPhoneNumber : entity.Value);
		}
		InternationalPrefix = prefix;
		NationalPhoneNumber = entity.NationalPhoneNumber;
		IsBlacklisted = entity.IsBlacklisted ?? false;
	}

	public void SetIsBlacklisted(bool isBlacklisted)
	{
		IPhoneNumberEntity obj = _DomainFactories.PhoneNumberEntityFactory.Get(base.Id) ?? throw new PlatformDataIntegrityException("Unable to find entity");
		obj.IsBlacklisted = isBlacklisted;
		obj.Update();
		IsBlacklisted = isBlacklisted;
	}

	public string GetPhoneNumberInE164Format()
	{
		if (string.IsNullOrEmpty(FullPhoneNumber))
		{
			return null;
		}
		return $"{'+'}{FullPhoneNumber}";
	}
}
