using System;
using Roblox.Instrumentation;
using Roblox.Instrumentation.LegacySupport;
using Roblox.Platform.Core;

namespace Roblox.Platform.Email.Delivery;

internal class EmailPerformanceMonitor : IEmailPerformanceMonitor
{
	private readonly ISimpleCounterCategoryFactory _SimpleCounterCategoryFactory;

	private readonly ISimpleCounterCategory _EmailCounterCategory;

	private readonly ICounterRegistry _CounterRegistry;

	internal EmailPerformanceMonitor(ICounterRegistry counterRegistry)
		: this(counterRegistry, new SimpleCounterCategoryFactory(counterRegistry))
	{
	}

	internal EmailPerformanceMonitor(ICounterRegistry counterRegistry, ISimpleCounterCategoryFactory simpleCounterCategoryFactory)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_SimpleCounterCategoryFactory = simpleCounterCategoryFactory ?? throw new PlatformArgumentNullException("simpleCounterCategoryFactory");
		_EmailCounterCategory = _SimpleCounterCategoryFactory.CreateSimpleCounterCategory("Roblox.Platform.Email.EmailCategory", Enum.GetNames(typeof(EmailCounter)));
	}

	public void RecordEmailSent(IEmail email)
	{
		if (email == null)
		{
			throw new PlatformArgumentNullException("email");
		}
		_EmailCounterCategory.IncrementTotalAndInstance(EmailCounter.EmailsSentPerSecond.ToString(), email.EmailType);
	}

	public void RecordEmailException(IEmail email, Exception exception = null)
	{
		if (email == null)
		{
			throw new PlatformArgumentNullException("email");
		}
		_EmailCounterCategory.IncrementTotalAndInstance(EmailCounter.EmailErrorsPerSecond.ToString(), email.EmailType);
	}
}
