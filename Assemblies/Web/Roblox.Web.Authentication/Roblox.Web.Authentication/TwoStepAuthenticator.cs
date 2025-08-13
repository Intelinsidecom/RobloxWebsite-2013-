using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using Roblox.Configuration;
using Roblox.Platform.Membership;
using Roblox.Platform.Security.SecureBlobs;
using Roblox.Platform.TwoStepVerification;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Web.Authentication;

/// <summary>
/// Implementation of <see cref="T:Roblox.Web.Authentication.ITwoStepAuthenticator" />
/// </summary>
public class TwoStepAuthenticator : ITwoStepAuthenticator
{
	private readonly ITwoStepVerificationSessionFactory _TwoStepVerificationSessionFactory;

	private readonly ITwoStepVerificationConfigurationProvider _TwoStepVerificationConfigurationProvider;

	private readonly ISecureBlobAuthority<Guid> _TwoStepSecureBlobAuthority;

	private const string _TwoStepSessionCookieName = ".RBXIDCHECK";

	[ExcludeFromCodeCoverage]
	protected virtual char CookieTokenListSeperator => ',';

	[ExcludeFromCodeCoverage]
	protected virtual int CookieTokenListMaxSize => Settings.Default.TwoStepCookieMaxTokenCount;

	[ExcludeFromCodeCoverage]
	protected virtual bool IsTwoStepVerificationEnabled => Settings.Default.IsTwoStepVerificationEnabled;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Web.Authentication.ITwoStepAuthenticator" />
	/// </summary>
	/// <param name="twoStepVerificationSessionFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionFactory" /></param>
	/// <param name="twoStepVerificationConfigurationProvider">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationConfigurationProvider" /></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="twoStepVerificationSessionFactory" /> or <paramref name="twoStepVerificationConfigurationProvider" /> is null.</exception>
	public TwoStepAuthenticator(ITwoStepVerificationSessionFactory twoStepVerificationSessionFactory, ITwoStepVerificationConfigurationProvider twoStepVerificationConfigurationProvider)
	{
		_TwoStepVerificationSessionFactory = twoStepVerificationSessionFactory ?? throw new ArgumentNullException("twoStepVerificationSessionFactory");
		_TwoStepVerificationConfigurationProvider = twoStepVerificationConfigurationProvider ?? throw new ArgumentNullException("twoStepVerificationConfigurationProvider");
		_TwoStepSecureBlobAuthority = new SecureBlobAuthority<Guid>(GenerateTwoStepChallengeSecret);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.ITwoStepAuthenticator.IsTwoStepChallengeRequired(Roblox.Platform.Membership.IUser)" />
	public bool IsTwoStepChallengeRequired(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!IsTwoStepVerificationEnabled)
		{
			return false;
		}
		if (!_TwoStepVerificationConfigurationProvider.GetTwoStepSettingForUser(user).IsEnabled)
		{
			return false;
		}
		string twoStepCookieValue = GetTwoStepSessionCookie()?.Value;
		if (string.IsNullOrWhiteSpace(twoStepCookieValue))
		{
			return true;
		}
		string[] cookieTokens = twoStepCookieValue.Split(CookieTokenListSeperator);
		List<string> savedTokens = new List<string>(cookieTokens);
		bool isRequired = true;
		bool cookieChanged = false;
		string[] array = cookieTokens;
		foreach (string cookieToken in array)
		{
			if (!Guid.TryParse(cookieToken, out var token))
			{
				savedTokens.Remove(cookieToken);
				cookieChanged = true;
				continue;
			}
			ITwoStepVerificationSession twoStepVerificationSession = _TwoStepVerificationSessionFactory.GetByToken(token);
			if (twoStepVerificationSession == null)
			{
				savedTokens.Remove(cookieToken);
				cookieChanged = true;
			}
			else if (user.Id == twoStepVerificationSession.UserIdentifier.Id)
			{
				if (cookieTokens[0] != cookieToken)
				{
					savedTokens.Remove(cookieToken);
					savedTokens.Insert(0, cookieToken);
					cookieChanged = true;
				}
				isRequired = false;
				break;
			}
		}
		if (cookieChanged)
		{
			SetTwoStepSessionCookie(string.Join(CookieTokenListSeperator.ToString(), savedTokens));
		}
		return isRequired;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.ITwoStepAuthenticator.StartTwoStepSession(Roblox.Platform.Membership.IUser)" />
	public void StartTwoStepSession(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		Guid token = _TwoStepVerificationSessionFactory.CreateNew(user).Token;
		string twoStepCookieValue = GetTwoStepSessionCookie()?.Value ?? "";
		List<string> cookieTokens = ((!string.IsNullOrWhiteSpace(twoStepCookieValue)) ? twoStepCookieValue.Split(CookieTokenListSeperator).ToList() : new List<string>());
		cookieTokens.Insert(0, token.ToString());
		while (cookieTokens.Count > CookieTokenListMaxSize && cookieTokens.Count > 0)
		{
			cookieTokens.RemoveAt(CookieTokenListMaxSize);
		}
		SetTwoStepSessionCookie(string.Join(CookieTokenListSeperator.ToString(), cookieTokens));
	}

	[ExcludeFromCodeCoverage]
	protected virtual IRobloxCookie GetTwoStepSessionCookie()
	{
		return RobloxCookie.Get(HttpContext.Current, ".RBXIDCHECK");
	}

	[ExcludeFromCodeCoverage]
	protected virtual void SetTwoStepSessionCookie(string value)
	{
		RobloxCookie twoStepCookie = RobloxCookie.GetOrCreate(HttpContext.Current, ".RBXIDCHECK");
		if (!HttpContext.Current.Request.IsLocal)
		{
			string domain = RobloxEnvironment.Domain;
			if (!string.IsNullOrEmpty(domain) && HttpContext.Current.Request.Url.Host.EndsWith(domain))
			{
				twoStepCookie.Domain = domain;
			}
		}
		twoStepCookie.Expires = DateTime.MaxValue;
		twoStepCookie.Value = value;
		twoStepCookie.HttpOnly = true;
		twoStepCookie.AppendToResponse();
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.ITwoStepAuthenticator.CreateChallengeSecureBlob(System.Guid)" />
	public string CreateChallengeSecureBlob(Guid id)
	{
		return _TwoStepSecureBlobAuthority.GenerateSecureBlob(id);
	}

	public Guid GetChallengeFromSecureBlobTicket(string ticket)
	{
		return _TwoStepSecureBlobAuthority.GetModelFromSecureBlob(ticket);
	}

	private string GenerateTwoStepChallengeSecret(Guid id)
	{
		return "TwoStepVerificationChallenge" + $"\nId:{id}";
	}
}
