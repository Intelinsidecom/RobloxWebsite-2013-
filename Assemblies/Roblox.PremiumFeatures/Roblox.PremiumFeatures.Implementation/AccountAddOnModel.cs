using System;
using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <inheritdoc />
public class AccountAddOnModel : IAccountAddOnModel
{
	/// <inheritdoc />
	public int Id { get; }

	/// <inheritdoc />
	public long AccountId { get; }

	/// <inheritdoc />
	public int PremiumFeatureId { get; }

	/// <inheritdoc />
	public DateTime? Renewal { get; }

	/// <inheritdoc />
	public DateTime Expiration { get; }

	/// <inheritdoc />
	public long? RobuxStipendId { get; }

	/// <inheritdoc />
	public DateTime Created { get; }

	/// <inheritdoc />
	public DateTime? RenewedSince { get; }

	/// <inheritdoc />
	public string Name { get; }

	/// <inheritdoc />
	public string AccountAddOnTypeName { get; }

	/// <inheritdoc />
	public bool IsLifetime { get; }

	/// <summary>
	/// Create new AccountAddOnModel
	/// </summary>
	/// <param name="id">AccountAddOn id</param>
	/// <param name="accountId">Account id</param>
	/// <param name="premiumFeatureId">PremiumFeature id</param>
	/// <param name="renewal">Renewal date</param>
	/// <param name="expiration">Expiration date</param>
	/// <param name="robuxStipendId">Robux stipend id</param>
	/// <param name="created">Created date</param>
	/// <param name="renewedSince">Original renewal date</param>
	/// <param name="name">PremiumFeature name</param>
	/// <param name="accountAddOnTypeName">AccountAddOn type name</param>
	/// <param name="isLifetime">Is lifetime</param>
	public AccountAddOnModel(int id, long accountId, int premiumFeatureId, DateTime? renewal, DateTime expiration, long? robuxStipendId, DateTime created, DateTime? renewedSince, string name, string accountAddOnTypeName, bool isLifetime)
	{
		Id = id;
		AccountId = accountId;
		PremiumFeatureId = premiumFeatureId;
		Renewal = renewal;
		Expiration = expiration;
		RobuxStipendId = robuxStipendId;
		Created = created;
		RenewedSince = renewedSince;
		Name = name;
		AccountAddOnTypeName = accountAddOnTypeName;
		IsLifetime = isLifetime;
	}
}
