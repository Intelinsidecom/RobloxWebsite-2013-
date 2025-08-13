using System;
using System.ComponentModel;
using System.Configuration;
using Roblox.Common.NetStandard;

namespace Roblox.Caching;

[TypeConverter(typeof(MigrationStateChangeConverter))]
[SettingsSerializeAs(/*Could not decode attribute arguments.*/)]
public class MigrationStateChange : IEquatable<MigrationStateChange>
{
	public readonly MigrationState SourceState;

	public readonly MigrationState DestinationState;

	private const int _OneThousand = 1000;

	public int RolloutPerThousand { get; internal set; }

	public bool IsSourceAndDestinationStateSame => SourceState == DestinationState;

	public MigrationStateChange(MigrationState sourceState, MigrationState destinationState, int rolloutPerThousand)
	{
		if (!Enum.IsDefined(typeof(MigrationState), sourceState))
		{
			throw new InvalidEnumArgumentException(string.Format("Could not parse {0} with value {1}", "sourceState", sourceState));
		}
		SourceState = sourceState;
		if (!Enum.IsDefined(typeof(MigrationState), destinationState))
		{
			throw new InvalidEnumArgumentException(string.Format("Could not parse {0} with value {1}", "destinationState", destinationState));
		}
		DestinationState = destinationState;
		if (rolloutPerThousand < 0 || rolloutPerThousand > 1000)
		{
			throw new ArgumentOutOfRangeException(string.Format("{0} can only be between 0 and 1000, both inclusive. Value was {1}", "rolloutPerThousand", rolloutPerThousand), "rolloutPerThousand");
		}
		RolloutPerThousand = rolloutPerThousand;
	}

	public MigrationStateChange(string migrationStateChange)
	{
		if (string.IsNullOrWhiteSpace(migrationStateChange))
		{
			SourceState = MigrationState.NoMigration;
			DestinationState = MigrationState.NoMigration;
			RolloutPerThousand = 0;
			return;
		}
		string[] array = migrationStateChange.Split(new char[1] { ',' });
		if (array.Length != 3)
		{
			throw new MigrationStateChangeParseException(string.Format("{0} should resolve to 2 MigrationStates and a rollout percentage separated by a ',' but it was {1}", "migrationStateChange", migrationStateChange));
		}
		SourceState = EnumUtils.StrictTryParseEnum<MigrationState>(array[0]) ?? throw new MigrationStateChangeParseException($"Could not resolve SourceState. Value was {array[0]}.");
		DestinationState = EnumUtils.StrictTryParseEnum<MigrationState>(array[1]) ?? throw new MigrationStateChangeParseException($"Could not resolve DestinationState. Value was {array[1]}.");
		if (!int.TryParse(array[2], out var result))
		{
			throw new MigrationStateChangeParseException($"Could not resolve Rollout Per Thousand. Value was {array[2]}");
		}
		RolloutPerThousand = result;
		if (RolloutPerThousand >= 0 && RolloutPerThousand <= 1000)
		{
			return;
		}
		throw new MigrationStateChangeParseException($"Rollout Per Thousand was out of range. Value was {array[2]}");
	}

	public override string ToString()
	{
		return string.Join(",", SourceState, DestinationState, RolloutPerThousand);
	}

	public bool Equals(MigrationStateChange other)
	{
		if ((object)other == null)
		{
			return false;
		}
		if ((object)this == other)
		{
			return true;
		}
		if (SourceState == other.SourceState && DestinationState == other.DestinationState)
		{
			return RolloutPerThousand == other.RolloutPerThousand;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() == GetType())
		{
			return Equals((MigrationStateChange)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)(((uint)((int)SourceState * 397) ^ (uint)DestinationState) * 397) ^ RolloutPerThousand;
	}

	public static bool operator ==(MigrationStateChange left, MigrationStateChange right)
	{
		return object.Equals(left, right);
	}

	public static bool operator !=(MigrationStateChange left, MigrationStateChange right)
	{
		return !object.Equals(left, right);
	}
}
