using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Roblox.GameInstances.Client;

public class GetCustomPlayerCountsByCustomKeyRequestModel
{
	private static readonly int _MaxNumberOfDimensions = 3;

	private static readonly int _MaxNumberOfCounts = 5;

	public long UniverseId { get; set; }

	public IReadOnlyCollection<CustomPlayerCountDimension> DimensionKeys { get; set; }

	public IReadOnlyCollection<CustomPlayerCount> Counts { get; set; }

	public bool Approximate { get; set; }

	public bool Validate()
	{
		if (DimensionKeys.Count > _MaxNumberOfDimensions || Counts.Count > _MaxNumberOfCounts)
		{
			throw new InvalidDataException("Exceeded maximum allowed model limits: " + ToString());
		}
		if (DimensionKeys.Any((CustomPlayerCountDimension v) => v.Dimension == CustomPlayerDimension.Unrecognized) || Counts.Any((CustomPlayerCount v) => v == CustomPlayerCount.Unrecognized) || DimensionKeys.Distinct().Count() < DimensionKeys.Count || Counts.Distinct().Count() < Counts.Count)
		{
			throw new InvalidDataException("Wrong model data: " + ToString());
		}
		return true;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder($"universeId:{UniverseId}:dimensionKeys:");
		foreach (CustomPlayerCountDimension dimensionKey in DimensionKeys)
		{
			stringBuilder.Append($":name:{dimensionKey.Dimension}");
			if (dimensionKey.Filter != null)
			{
				stringBuilder.Append(":filter:" + string.Join(",", dimensionKey.Filter));
			}
		}
		stringBuilder.Append(":counts:" + string.Join(",", Counts));
		return stringBuilder.ToString();
	}
}
