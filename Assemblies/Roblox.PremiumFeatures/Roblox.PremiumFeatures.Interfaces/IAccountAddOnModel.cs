using System;

namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// AccountAddOnModel interface
/// </summary>
public interface IAccountAddOnModel
{
	/// <summary>
	/// AccountAddOn id
	/// </summary>
	int Id { get; }

	/// <summary>
	/// Account id
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// PremiumFeature id
	/// </summary>
	int PremiumFeatureId { get; }

	/// <summary>
	/// Renewal date
	/// </summary>
	DateTime? Renewal { get; }

	/// <summary>
	/// Expiration date
	/// </summary>
	DateTime Expiration { get; }

	/// <summary>
	/// Robux stipend id
	/// </summary>
	long? RobuxStipendId { get; }

	/// <summary>
	/// Created date
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// Original renewal date
	/// </summary>
	DateTime? RenewedSince { get; }

	/// <summary>
	/// Name of premiumFeature
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Name of AccountAddOnType
	/// </summary>
	string AccountAddOnTypeName { get; }

	/// <summary>
	/// Is lifetime
	/// </summary>
	bool IsLifetime { get; }
}
