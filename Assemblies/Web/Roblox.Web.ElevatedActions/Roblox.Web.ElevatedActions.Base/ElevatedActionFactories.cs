using System;
using Roblox.Instrumentation;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Sms.Client;

namespace Roblox.Web.ElevatedActions.Base;

public class ElevatedActionFactories : IElevatedActionFactories
{
	public IUserFactory UserFactory { get; }

	public IElevatedActionFactory ElevatedActionFactory { get; }

	public IRoleSetElevatedActionFactory RoleSetElevatedActionFactory { get; }

	public IRoleSetValidator RoleSetValidator { get; }

	public ICounterRegistry CounterRegistry { get; }

	public IEmailSender EmailSender { get; }

	public ISmsClient SmsClient { get; }

	public IAccountPhoneNumberFactory AccountPhoneNumberFactory { get; }

	public IHttpRequestKeyInfoExtractor HttpRequestKeyInfoExtractor { get; }

	public IRobloxElevatedActionPerformanceCounterFactory RobloxElevatedActionPerformanceCounterFactory { get; }

	public ElevatedActionFactories(IUserFactory userFactory, IEmailSender emailSender, ISmsClient smsClient, IAccountPhoneNumberFactory accountPhoneNumberFactory, IElevatedActionFactory elevatedActionFactory, IRoleSetElevatedActionFactory roleSetElevatedActionFactory, IRoleSetValidator roleSetValidator, ICounterRegistry counterRegistry, IHttpRequestKeyInfoExtractor httpRequestKeyInfoExtractor, IRobloxElevatedActionPerformanceCounterFactory robloxElevatedActionPerformanceCounterFactory)
	{
		UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		EmailSender = emailSender ?? throw new ArgumentNullException("emailSender");
		AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new ArgumentNullException("accountPhoneNumberFactory");
		ElevatedActionFactory = elevatedActionFactory ?? throw new ArgumentNullException("elevatedActionFactory");
		RoleSetElevatedActionFactory = roleSetElevatedActionFactory ?? throw new ArgumentNullException("roleSetElevatedActionFactory");
		RoleSetValidator = roleSetValidator ?? throw new ArgumentNullException("roleSetValidator");
		CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		HttpRequestKeyInfoExtractor = httpRequestKeyInfoExtractor ?? throw new ArgumentNullException("httpRequestKeyInfoExtractor");
		RobloxElevatedActionPerformanceCounterFactory = robloxElevatedActionPerformanceCounterFactory ?? throw new ArgumentNullException("robloxElevatedActionPerformanceCounterFactory");
		SmsClient = smsClient ?? throw new ArgumentNullException("smsClient");
	}
}
