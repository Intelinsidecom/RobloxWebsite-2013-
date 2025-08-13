using System;
using System.Web;
using System.Web.UI;
using Roblox.Instrumentation;
using Roblox.Web.Metrics.Properties;

namespace Roblox.Web.Metrics;

/// <inheritdoc cref="T:Roblox.Web.Metrics.IAspNetStatisticsTracker" />
public class AspNetStatisticsTracker : IAspNetStatisticsTracker
{
	private readonly IWebResponseMetricsFactory _WebResponseMetricsFactory;

	internal virtual bool AreAspNetMetricsEnabled => Settings.Default.AreAspNetMetricsEnabled;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.AspNetStatisticsTracker" />.
	/// </summary>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCounterNamespace">The performance counter namespace.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="performanceCounterNamespace" /> is null or whitespace.</exception>
	public AspNetStatisticsTracker(ICounterRegistry counterRegistry, string performanceCounterNamespace)
		: this(new WebResponseMetricsFactory(counterRegistry, performanceCounterNamespace))
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.AspNetStatisticsTracker" />.
	/// </summary>
	/// <remarks>
	/// Constructor exists for tests, consumers should use counter namespace constructor.
	/// </remarks>
	/// <param name="webResponseMetricsFactory">The <see cref="T:Roblox.Web.Metrics.IWebResponseMetricsFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="webResponseMetricsFactory" /></exception>
	internal AspNetStatisticsTracker(IWebResponseMetricsFactory webResponseMetricsFactory)
	{
		_WebResponseMetricsFactory = webResponseMetricsFactory ?? throw new ArgumentNullException("webResponseMetricsFactory");
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IAspNetStatisticsTracker.OnAspxPageChosen(System.Web.UI.Page)" />
	public void OnAspxPageChosen(Page page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		OnAspxPageChosen(page.GetType().Name, null);
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IAspNetStatisticsTracker.OnAspxPageChosen(System.String,System.String)" />
	public void OnAspxPageChosen(string pageName, string methodName)
	{
		if (string.IsNullOrWhiteSpace(pageName))
		{
			throw new ArgumentNullException("pageName");
		}
		if (AreAspNetMetricsEnabled)
		{
			string instanceName = pageName;
			if (!string.IsNullOrWhiteSpace(methodName))
			{
				instanceName += $":{methodName}";
			}
			_WebResponseMetricsFactory.GetAspNetPerformanceCounter(AspNetPageType.Aspx, instanceName).IncrementRequest();
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IAspNetStatisticsTracker.OnAshxPageChosen(System.Web.IHttpHandler)" />
	public void OnAshxPageChosen(IHttpHandler page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (AreAspNetMetricsEnabled)
		{
			_WebResponseMetricsFactory.GetAspNetPerformanceCounter(AspNetPageType.Ashx, page.GetType().Name).IncrementRequest();
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IAspNetStatisticsTracker.OnAscxPageChosen(System.Web.UI.UserControl)" />
	public void OnAscxPageChosen(UserControl userControl)
	{
		if (userControl == null)
		{
			throw new ArgumentNullException("userControl");
		}
		if (AreAspNetMetricsEnabled)
		{
			_WebResponseMetricsFactory.GetAspNetPerformanceCounter(AspNetPageType.Ascx, userControl.GetType().Name).IncrementRequest();
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IAspNetStatisticsTracker.OnAsmxServiceMethodChosen(System.String,System.String)" />
	public void OnAsmxServiceMethodChosen(string serviceName, string methodName)
	{
		if (string.IsNullOrWhiteSpace(serviceName))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "serviceName");
		}
		if (string.IsNullOrWhiteSpace(methodName))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "methodName");
		}
		_WebResponseMetricsFactory.GetAspNetPerformanceCounter(AspNetPageType.Asmx, $"{serviceName}:{methodName}").IncrementRequest();
	}
}
