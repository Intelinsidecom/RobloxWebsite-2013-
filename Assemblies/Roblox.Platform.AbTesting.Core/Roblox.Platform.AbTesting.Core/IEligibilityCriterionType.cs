namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface for an object that defines a criterion for eligibility.
/// </summary>
public interface IEligibilityCriterionType
{
	int Id { get; }

	string Value { get; }
}
