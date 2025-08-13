using System;
using System.Collections.Generic;
using Gigya.Socialize.SDK;
using Roblox.Gigya.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Gigya;

internal class GigyaUser : IGigyaUser, IGigyaValidatable
{
	internal readonly IGigyaValidator _GigyaValidator;

	public string UID { get; private set; }

	public string Signature { get; private set; }

	public int Timestamp { get; private set; }

	public string ErrorMessage { get; internal set; }

	public bool IsValid { get; internal set; }

	public string FirstName { get; private set; }

	public string Nickname { get; private set; }

	public DateTime? Birthday { get; private set; }

	public GenderType Gender { get; private set; }

	public string Email { get; private set; }

	public string PhotoUrl { get; private set; }

	public GigyaProviderType LoginProvider { get; private set; }

	public string LoginProviderUID { get; private set; }

	public ICollection<IGigyaIdentity> Identities { get; private set; }

	/// <summary>
	/// Should this user be validated upon creation?.
	/// </summary>
	protected virtual bool IsValidationEnabled => Settings.Default.IsGigyaGetUserInfoResponseValidationEnabled;

	protected virtual IGigyaIdentity BuildIdentity(GSObject data)
	{
		return new GigyaIdentity(data);
	}

	public GigyaUser(GSObject data)
		: this(data, new GigyaValidator())
	{
	}

	public GigyaUser(GSObject data, IGigyaValidator gigyaValidator)
	{
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (gigyaValidator == null)
		{
			throw new ArgumentNullException("gigyaValidator");
		}
		_GigyaValidator = gigyaValidator;
		UID = data.GetString("UID", string.Empty);
		Signature = data.GetString("UIDSignature", string.Empty);
		Timestamp = data.GetInt("signatureTimestamp", 0);
		if (IsValidationEnabled)
		{
			IsValid = _GigyaValidator.Validate(this, out var errorMessage);
			ErrorMessage = errorMessage;
		}
		else
		{
			IsValid = true;
		}
		FirstName = data.GetString("firstName", string.Empty);
		Nickname = data.GetString("nickname", "Anonymous");
		Email = data.GetString("email", string.Empty);
		PhotoUrl = data.GetString("photoURL", string.Empty);
		LoginProvider = GigyaProviderTranslator.TranslateToGigyaProvider(data.GetString("loginProvider", string.Empty));
		LoginProviderUID = data.GetString("loginProviderUID", string.Empty);
		Birthday = null;
		if (data.ContainsKey("birthYear") && data.ContainsKey("birthMonth") && data.ContainsKey("birthDay"))
		{
			int year = data.GetInt("birthYear", 0);
			int month = data.GetInt("birthMonth", 0);
			int day = data.GetInt("birthDay", 0);
			if (year > 0 && month > 0 && day > 0)
			{
				try
				{
					Birthday = new DateTime(year, month, day);
				}
				catch (ArgumentOutOfRangeException)
				{
				}
			}
		}
		Gender = GenderType.Unknown;
		if (data.ContainsKey("gender"))
		{
			switch (data.GetString("gender", "u"))
			{
			case "m":
				Gender = GenderType.Male;
				break;
			case "f":
				Gender = GenderType.Female;
				break;
			default:
				Gender = GenderType.Unknown;
				break;
			}
		}
		Identities = new List<IGigyaIdentity>();
		if (!data.ContainsKey("identities"))
		{
			return;
		}
		foreach (GSObject item in data.GetArray("identities"))
		{
			GSObject identity = item;
			IGigyaIdentity newIdentity = BuildIdentity(identity);
			Identities.Add(newIdentity);
		}
	}
}
