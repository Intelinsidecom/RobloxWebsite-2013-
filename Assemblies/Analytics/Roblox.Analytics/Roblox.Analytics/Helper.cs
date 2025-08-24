using System;
using System.Collections.Generic;
using Roblox.Analytics.Properties;

namespace Roblox.Analytics;

public class Helper
{
	internal static readonly string DBConnectionString = Settings.Default.dbConnectionString_RobloxReporting;

	private static void CreateValidatedDoubleDataItem(Measurement measurement, string key, double value)
	{
		Expression i = Expression.GetOrCreate(key);
		if (double.IsInfinity(value) || double.IsNaN(value))
		{
			Expression.GetOrCreate(value.ToString());
			StringDataItem.CreateNew(measurement, key, value.ToString());
		}
		else
		{
			DoubleDataItem.CreateNew(measurement, i, value);
		}
	}

	private static void DoLogMeasurement(string type, DateTime measurementDateTime, KeyValuePair<string, string>? filter, KeyValuePair<string, string>? secondaryFilter, ICollection<KeyValuePair<string, string>> stringData, ICollection<KeyValuePair<string, double>> doubleData)
	{
		try
		{
			MeasurementType orCreate = MeasurementType.GetOrCreate(type);
			Filter filter2 = (filter.HasValue ? Filter.GetOrCreate(filter.Value.Key, filter.Value.Value) : null);
			Filter filter3 = (secondaryFilter.HasValue ? Filter.GetOrCreate(secondaryFilter.Value.Key, secondaryFilter.Value.Value) : null);
			Measurement measurement = Measurement.CreateNew(orCreate, measurementDateTime, filter2, filter3);
			if (stringData != null)
			{
				foreach (KeyValuePair<string, string> datum2 in stringData)
				{
					StringDataItem.CreateNew(measurement, datum2.Key, datum2.Value);
				}
			}
			if (doubleData == null)
			{
				return;
			}
			foreach (KeyValuePair<string, double> datum in doubleData)
			{
				CreateValidatedDoubleDataItem(measurement, datum.Key, datum.Value);
			}
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}

	public static void LogMeasurement(string type, DateTime measurementDateTime, KeyValuePair<string, string>? filter, KeyValuePair<string, string>? secondaryFilter)
	{
		LogMeasurement(type, measurementDateTime, filter, secondaryFilter, null, null);
	}

	public static void LogMeasurement(string type, DateTime measurementDateTime, KeyValuePair<string, string>? filter, KeyValuePair<string, string>? secondaryFilter, ICollection<KeyValuePair<string, string>> stringData, ICollection<KeyValuePair<string, double>> doubleData)
	{
		if (string.IsNullOrEmpty(type))
		{
			throw new ArgumentException("Required value not specified: MeasurementType.");
		}
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			DoLogMeasurement(type, measurementDateTime, filter, secondaryFilter, stringData, doubleData);
		});
	}
}
