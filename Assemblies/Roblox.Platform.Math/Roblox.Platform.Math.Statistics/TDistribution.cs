using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Roblox.Platform.Math.Statistics;

public static class TDistribution
{
	private static readonly SortedDictionary<int, double> _90th;

	private static readonly SortedDictionary<int, double> _95th;

	private static readonly SortedDictionary<int, double> _99th;

	private static readonly SortedDictionary<int, double> _99p9th;

	public static double TCritical(int dof, Confidence conf)
	{
		if (dof <= 0)
		{
			return double.MaxValue;
		}
		int mappedDOF = GetMappedDOF(dof);
		return conf switch
		{
			Confidence.C95 => _95th[mappedDOF], 
			Confidence.C99 => _99th[mappedDOF], 
			Confidence.C99p9 => _99p9th[mappedDOF], 
			_ => _90th[mappedDOF], 
		};
	}

	static TDistribution()
	{
		_90th = new SortedDictionary<int, double>();
		_95th = new SortedDictionary<int, double>();
		_99th = new SortedDictionary<int, double>();
		_99p9th = new SortedDictionary<int, double>();
		try
		{
			using Stream csvStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Roblox.Platform.Math.Statistics.TDistribution.csv");
			using StreamReader csvReader = new StreamReader(csvStream);
			string line;
			while ((line = csvReader.ReadLine()) != null)
			{
				string[] values = Regex.Split(line, ",");
				if (values != null && values.Length == 5)
				{
					int dof = int.Parse(values[0]);
					_90th.Add(dof, double.Parse(values[1]));
					_95th.Add(dof, double.Parse(values[2]));
					_99th.Add(dof, double.Parse(values[3]));
					_99p9th.Add(dof, double.Parse(values[4]));
				}
			}
		}
		catch (Exception ex)
		{
			throw new MathException("TDistribution could not read CSV file", ex);
		}
	}

	private static int GetMappedDOF(int dof)
	{
		if (dof <= 0)
		{
			return 0;
		}
		if (dof <= 30 || dof == 120)
		{
			return dof;
		}
		if (dof < 40)
		{
			return 30;
		}
		if (dof < 50)
		{
			return 40;
		}
		if (dof < 60)
		{
			return 50;
		}
		if (dof < 80)
		{
			return 60;
		}
		if (dof < 100)
		{
			return 80;
		}
		if (dof < 120)
		{
			return 100;
		}
		return 121;
	}
}
