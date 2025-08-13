using System;
using System.Collections.Generic;
using Roblox.Assets.Properties;
using Roblox.Common;

namespace Roblox.Assets;

[Obsolete("Should reference AssetSearch databse directly.")]
public class Search
{
	private static RoundRobin<string> _ConnectionStrings;

	static Search()
	{
		UpdateConnectionStrings();
		Settings.Default.PropertyChanged += delegate
		{
			UpdateConnectionStrings();
		};
	}

	private static void AddConnection(ICollection<string> connectionStrings, string connectionString)
	{
		if (!string.IsNullOrEmpty(connectionString))
		{
			connectionStrings.Add(connectionString);
		}
	}

	private static void UpdateConnectionStrings()
	{
		List<string> obj = new List<string> { Settings.Default.AssetSearchDB };
		AddConnection(obj, Settings.Default.AssetSearchDB2);
		AddConnection(obj, Settings.Default.AssetSearchDB3);
		AddConnection(obj, Settings.Default.AssetSearchDB4);
		AddConnection(obj, Settings.Default.AssetSearchDB5);
		AddConnection(obj, Settings.Default.AssetSearchDB6);
		AddConnection(obj, Settings.Default.AssetSearchDB7);
		AddConnection(obj, Settings.Default.AssetSearchDB8);
		_ConnectionStrings = new RoundRobin<string>(obj);
	}

	public static string GetConnectionString()
	{
		return _ConnectionStrings.Next();
	}
}
