using System;
using System.Diagnostics.CodeAnalysis;
using System.Web;
using Roblox.Common;
using Roblox.EphemeralCounters;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Authentication;
using Roblox.Platform.Floodcheckers;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Enums;
using Roblox.Web.Authentication.Floodcheckers;

namespace Roblox.Web.Authentication.Verification;

/// <summary>
/// A base class that verifies credentials.
/// </summary>
internal abstract class BaseCredentialsVerifier : ICredentialsVerifier
{
	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private const string _CountersPrefix = "CredentialsVerifier";

	private const string _CountersSendCredentialsVerificationMessageNamespace = "SendCredentialsVerificationMessage";

	private const string _CountersAttemptSuffix = "Attempt";

	private const string _CountersFailSuffix = "Fail";

	protected CredentialsType CredentialsTypeToVerify { get; }

	/// <summary>
	/// A base constructor for a class that verifies credentials.
	/// </summary>
	/// <param name="credentialsType">The <see cref="T:Roblox.Platform.Authentication.CredentialsType" /> this class verifies.</param>
	/// <param name="ephemeralCounterFactory">A <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="ephemeralCounterFactory" /> is null.</exception>
	protected BaseCredentialsVerifier(CredentialsType credentialsType, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		_EphemeralCounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
		CredentialsTypeToVerify = credentialsType;
	}

	/// <summary>
	/// Sends a verification message to a user.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="credentialsValue">The <see cref="P:Roblox.Platform.Authentication.IRobloxUserCredentials.CredentialValue" /> of the <paramref name="user" /></param>
	/// <returns>A <see cref="T:Roblox.Web.Authentication.Enums.SendVerificationMessageStatus" />.</returns>
	public abstract SendVerificationMessageStatus SendVerificationMessageToUser(IUser user, string credentialsValue);

	/// <inheritdoc />
	public bool CanSendCredentialsVerificationMessage(IRobloxUnverifiedUserCredentials credentials)
	{
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		if (IsCanSendCredentialsVerificationMessageFlooded(credentials.CredentialsType, credentials.CredentialValue))
		{
			throw new FloodedException("Can send credentials verification message flooded.");
		}
		try
		{
			if (credentials.GetUserFromUnverifiedCredentials() == null)
			{
				return false;
			}
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	/// <inheritdoc />
	public SendVerificationMessageStatus SendCredentialsVerificationMessage(IRobloxUnverifiedUserCredentials credentials)
	{
		IncrementCounter("SendCredentialsVerificationMessage", "Attempt");
		if (credentials == null)
		{
			IncrementCounter("SendCredentialsVerificationMessage", "Fail");
			throw new ArgumentNullException("credentials");
		}
		if (credentials.CredentialsType != CredentialsTypeToVerify)
		{
			IncrementCounter("SendCredentialsVerificationMessage", "Fail");
			throw new ArgumentException($"Credentials type {credentials.CredentialsType} does not match allowed credentials type {CredentialsTypeToVerify}.");
		}
		if (string.IsNullOrWhiteSpace(credentials.CredentialValue))
		{
			IncrementCounter("SendCredentialsVerificationMessage", "Fail");
			throw new ArgumentException("CredentialValue");
		}
		string ipAddress = GetOriginIP();
		IFloodChecker ipFloodcheckers = GetSendVerificationMessageIpFloodCheckers(ipAddress, credentials.CredentialsType, credentials.CredentialValue);
		if (ipFloodcheckers.IsFlooded())
		{
			IncrementStatusCounter(SendVerificationMessageStatus.Flooded);
			return SendVerificationMessageStatus.Flooded;
		}
		ipFloodcheckers.UpdateCount();
		IUser user;
		try
		{
			user = credentials.GetUserFromUnverifiedCredentials();
			if (user == null)
			{
				IncrementStatusCounter(SendVerificationMessageStatus.UserNotFound);
				return SendVerificationMessageStatus.UserNotFound;
			}
		}
		catch (TooManyUsersLinkedToCredentialsException)
		{
			IncrementStatusCounter(SendVerificationMessageStatus.TooManyUsersPerCredentials);
			return SendVerificationMessageStatus.TooManyUsersPerCredentials;
		}
		catch (MultipleUsersPerCredentialException)
		{
			IncrementStatusCounter(SendVerificationMessageStatus.MultipleUsersPerCredentials);
			return SendVerificationMessageStatus.MultipleUsersPerCredentials;
		}
		IFloodChecker userIdFloodChecker = GetSendVerificationMessageUserIdFloodChecker(user.Id);
		if (userIdFloodChecker.IsFlooded())
		{
			IncrementStatusCounter(SendVerificationMessageStatus.Flooded);
			return SendVerificationMessageStatus.Flooded;
		}
		userIdFloodChecker.UpdateCount();
		SendVerificationMessageStatus status = SendVerificationMessageToUser(user, credentials.CredentialValue);
		IncrementStatusCounter(status);
		return status;
	}

	protected void IncrementCounter(string countersNamespace, string suffix)
	{
		string counterName = string.Format("{0}_{1}_{2}{3}", "CredentialsVerifier", countersNamespace, CredentialsTypeToVerify, suffix);
		_EphemeralCounterFactory.GetCounter(counterName).IncrementInBackground();
	}

	private void IncrementStatusCounter(SendVerificationMessageStatus status)
	{
		IncrementCounter("SendCredentialsVerificationMessage", status.ToString());
	}

	private bool IsCanSendCredentialsVerificationMessageFlooded(CredentialsType credentialsType, string credentialValue)
	{
		string ipAddress = GetOriginIP();
		IFloodChecker ipAndCredentialsFloodchecker = GetCanSendCredentialsVerificationMessageIpFloodcheckers(ipAddress, credentialsType, credentialValue);
		if (ipAndCredentialsFloodchecker.IsFlooded())
		{
			return true;
		}
		ipAndCredentialsFloodchecker.UpdateCount();
		return false;
	}

	[ExcludeFromCodeCoverage]
	internal virtual IFloodChecker GetCanSendCredentialsVerificationMessageIpFloodcheckers(string ipAddress, CredentialsType credentialsType, string credentialsValue)
	{
		CanSendVerificationMessageByIpFloodChecker ipFloodChecker = new CanSendVerificationMessageByIpFloodChecker(ipAddress);
		CanSendVerificationMessageByIpAndCredentialsFloodChecker ipAndCredentialsFloodChecker = new CanSendVerificationMessageByIpAndCredentialsFloodChecker(ipAddress, credentialsType, credentialsValue);
		return new FloodCheckerList { ipFloodChecker, ipAndCredentialsFloodChecker };
	}

	[ExcludeFromCodeCoverage]
	internal virtual IFloodChecker GetSendVerificationMessageIpFloodCheckers(string ipAddress, CredentialsType credentialsType, string credentialsValue)
	{
		SendVerificationMessageByIpFloodChecker ipFloodChecker = new SendVerificationMessageByIpFloodChecker(ipAddress);
		SendVerificationMessageByIpAndCredentialsFloodChecker ipAndCredentialsFloodChecker = new SendVerificationMessageByIpAndCredentialsFloodChecker(ipAddress, credentialsType, credentialsValue);
		return new FloodCheckerList { ipFloodChecker, ipAndCredentialsFloodChecker };
	}

	[ExcludeFromCodeCoverage]
	internal virtual IFloodChecker GetSendVerificationMessageUserIdFloodChecker(long userId)
	{
		return new SendVerificationMessageByUserIdFloodChecker(userId);
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GetOriginIP()
	{
		return HttpContext.Current.GetOriginIP();
	}
}
