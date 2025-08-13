using System;
using System.Collections.Generic;
using Roblox.Platform.Membership.Properties;
using Roblox.Random;

namespace Roblox.Platform.Membership;

/// <summary>
/// Generates a user name in the form of "{ReservedUsernamePrefix}{RandomNumber}"
/// </summary>
public class PrefixUsernameGenerator : IUsernameGenerator
{
	private static readonly IList<int> PiiFilteredSuffixLengths = new int[2] { 10, 11 };

	private readonly IRandomFactory _RandomFactory;

	internal virtual ISettings Settings => Roblox.Platform.Membership.Properties.Settings.Default;

	/// <summary>
	/// Initializes a new PrefixUsernameGenerator
	/// </summary>
	/// <param name="randomFactory">The <see cref="T:Roblox.Random.IRandomFactory" /></param>
	public PrefixUsernameGenerator(IRandomFactory randomFactory)
	{
		_RandomFactory = randomFactory ?? throw new ArgumentNullException("randomFactory");
	}

	/// <inheritdoc />
	public string GenerateUsername()
	{
		int maxSuffixLength = Settings.MaxGeneratedUsernameSuffixLength;
		int minSuffixLength = Settings.MinGeneratedUsernameSuffixLength;
		string prefix = Settings.ReservedUsernamePrefix;
		if (string.IsNullOrWhiteSpace(prefix))
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0} cannot be null or whitespace.", "ReservedUsernamePrefix"));
		}
		if (maxSuffixLength < 1)
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0} cannot be less than 1.", "MaxGeneratedUsernameSuffixLength"));
		}
		if (minSuffixLength < 1)
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0} cannot be less than 1.", "MinGeneratedUsernameSuffixLength"));
		}
		if (minSuffixLength > maxSuffixLength)
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0} cannot be greater than {1}.", "MinGeneratedUsernameSuffixLength", "MaxGeneratedUsernameSuffixLength"));
		}
		if (maxSuffixLength + prefix.Length > Settings.MaxAllowedUsernameLength)
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0} + {1}.Length ", "MaxGeneratedUsernameSuffixLength", "ReservedUsernamePrefix") + string.Format("cannot be greater than {0}.", "MaxAllowedUsernameLength"));
		}
		if (minSuffixLength + prefix.Length < Settings.MinAllowedUsernameLength)
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0}.Length + {1} ", "ReservedUsernamePrefix", "MinGeneratedUsernameSuffixLength") + string.Format("cannot be less than than {0}.", "MinAllowedUsernameLength"));
		}
		if (PiiFilteredSuffixLengths.Contains(maxSuffixLength))
		{
			throw new InvalidUsernameGeneratorSettingsException(string.Format("{0} cannot be a filtered length.", "MaxGeneratedUsernameSuffixLength"));
		}
		double num = _RandomFactory.GetDefaultRandom().NextDouble();
		double minSuffix = Math.Pow(10.0, minSuffixLength - 1);
		double maxSuffix = Math.Pow(10.0, maxSuffixLength);
		ulong suffix = (ulong)(num * (maxSuffix - minSuffix) + minSuffix);
		return prefix + suffix;
	}
}
