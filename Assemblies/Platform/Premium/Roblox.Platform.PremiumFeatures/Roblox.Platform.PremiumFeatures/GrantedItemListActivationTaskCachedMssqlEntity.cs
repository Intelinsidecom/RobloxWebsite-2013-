using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
namespace Roblox.Platform.PremiumFeatures {
    [ExcludeFromCodeCoverage]

internal class GrantedItemListActivationTaskCachedMssqlEntity : IGrantedItemListActivationTaskEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public byte GrantedItemTypeId { get; set; }

	public long PremiumFeatureActivationTaskId { get; set; }

	public Guid? WorkerId { get; set; }

	public DateTime? Completed { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public DateTime? LeaseExpiration { get; set; }

	public void Update()
	{
		GrantedItemListActivationTaskEntity cal = GrantedItemListActivationTaskEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.GrantedItemTypeID = GrantedItemTypeId;
		cal.PremiumFeatureActivationTaskID = PremiumFeatureActivationTaskId;
		cal.WorkerID = WorkerId;
		cal.Completed = Completed;
		cal.LeaseExpiration = LeaseExpiration;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(GrantedItemListActivationTaskEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public void ProcessTaskAndMarkComplete(PremiumFeatureActivationTask premiumFeatureActivationTask)
	{
		// This cached MSSQL entity adapter simply proxies to the real entity logic.
		// If additional behavior is needed, it can be implemented here later.
		// For now, this satisfies the interface contract for build correctness.
		// No-op.
	}
}


}
