using System.Text.RegularExpressions;
using Prometheus;

namespace Roblox.Instrumentation.PrometheusListener;

internal class GaugeWrapper
{
	private readonly Gauge.Child _GaugeChild;

	public GaugeWrapper(string variableName, string instance, string category, string helpText)
	{
		string name = Regex.Replace(variableName, "[^a-zA-Z0-9_:]", "_");
		string text = ((instance == null) ? "null" : Regex.Replace(instance, "[^a-zA-Z0-9_:]", "_"));
		string text2 = ((category == null) ? "null" : Regex.Replace(category, "[^a-zA-Z0-9_:]", "_"));
		Gauge gauge = Metrics.CreateGauge(name, helpText, new GaugeConfiguration
		{
			LabelNames = new string[6] { "instance", "category", "machineName", "host", "serverFarm", "superFarm" }
		});
		_GaugeChild = gauge.WithLabels(text, text2, PrometheusServerWrapper.Instance.MachineName, PrometheusServerWrapper.Instance.HostIdentifier, PrometheusServerWrapper.Instance.ServerFarmIdentifier, PrometheusServerWrapper.Instance.SuperFarmIdentifier);
	}

	internal void Set(double val)
	{
		if (PrometheusServerWrapper.Instance.UpdatingCountersEnabled)
		{
			_GaugeChild.Set(val);
		}
	}

	internal void Inc(double val)
	{
		if (PrometheusServerWrapper.Instance.UpdatingCountersEnabled)
		{
			_GaugeChild.Inc(val);
		}
	}

	internal void Dec(double val)
	{
		if (PrometheusServerWrapper.Instance.UpdatingCountersEnabled)
		{
			_GaugeChild.Dec(val);
		}
	}
}
