using Roblox.Instrumentation;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Sms.Client;

namespace Roblox.Web.ElevatedActions.Base;

/// <summary>
/// Factories needed by Elevated Actions
/// </summary>
public interface IElevatedActionFactories
{
	/// <summary>
	/// Provides a <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" />
	/// </summary>
	IAccountPhoneNumberFactory AccountPhoneNumberFactory { get; }

	/// <summary>
	/// Provides an <see cref="T:Roblox.Platform.Email.Delivery.IEmailSender" />
	/// </summary>
	IEmailSender EmailSender { get; }

	/// <summary>
	/// Provides an <see cref="T:Roblox.Sms.Client.ISmsClient" />
	/// </summary>
	ISmsClient SmsClient { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	IUserFactory UserFactory { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Web.ElevatedActions.Base.IElevatedActionFactory" />
	/// </summary>
	IElevatedActionFactory ElevatedActionFactory { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Web.ElevatedActions.Base.IRoleSetElevatedActionFactory" />
	/// </summary>
	IRoleSetElevatedActionFactory RoleSetElevatedActionFactory { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Platform.Membership.IRoleSetValidator" />
	/// </summary>
	IRoleSetValidator RoleSetValidator { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Instrumentation.ICounterRegistry" />
	/// </summary>
	ICounterRegistry CounterRegistry { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Web.ElevatedActions.Base.IHttpRequestKeyInfoExtractor" />
	/// </summary>
	IHttpRequestKeyInfoExtractor HttpRequestKeyInfoExtractor { get; }

	/// <summary>
	/// Provides a <see cref="T:Roblox.Web.ElevatedActions.Base.IRobloxElevatedActionPerformanceCounterFactory" />
	/// </summary>
	IRobloxElevatedActionPerformanceCounterFactory RobloxElevatedActionPerformanceCounterFactory { get; }
}
