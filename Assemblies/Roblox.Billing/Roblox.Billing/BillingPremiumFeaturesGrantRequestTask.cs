using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.EventLog;
using Roblox.PremiumFeatures;

namespace Roblox.Billing;

public class BillingPremiumFeaturesGrantRequestTask : IParallelWorkTask
{
	private IPremiumFeatureActivationTaskFactory _PremiumFeatureActivationTaskFactory;

	private SaleProductPremiumFeatureQueue _SaleProductPremiumFeatureQueue;

	public string UniqueId => _SaleProductPremiumFeatureQueue.ID.ToString();

	internal static ICollection<IParallelWorkTask> LeaseWorkItems(Guid workerId, int numberOfItems, int leaseDurationInMinutes, ILogger logger, IPremiumFeatureActivationTaskFactory premiumFeatureActivationTaskFactory)
	{
		if (premiumFeatureActivationTaskFactory == null)
		{
			throw new ArgumentNullException("premiumFeatureActivationTaskFactory");
		}
		ICollection<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		if (!BillingHelper.Enabled)
		{
			return entities;
		}
		foreach (long id in SaleProductPremiumFeatureQueueDAL.LeasePendingPremiumFeaturesToAward(workerId, numberOfItems, leaseDurationInMinutes))
		{
			try
			{
				SaleProductPremiumFeatureQueueDAL entityDal = SaleProductPremiumFeatureQueueDAL.Get(id);
				if (entityDal != null)
				{
					BillingPremiumFeaturesGrantRequestTask task = new BillingPremiumFeaturesGrantRequestTask
					{
						_PremiumFeatureActivationTaskFactory = premiumFeatureActivationTaskFactory
					};
					SaleProductPremiumFeatureQueue entity = new SaleProductPremiumFeatureQueue();
					entity.Construct(entityDal);
					task._SaleProductPremiumFeatureQueue = entity;
					CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
					entities.Add(task);
				}
			}
			catch (Exception ex)
			{
				logger.Error(ex);
			}
		}
		return entities;
	}

	public void ProcessTaskAndMarkComplete()
	{
		if (_PremiumFeatureActivationTaskFactory == null)
		{
			throw new ArgumentNullException("_PremiumFeatureActivationTaskFactory");
		}
		if (!_SaleProductPremiumFeatureQueue.PremiumFeatureGrantRequested && !(_SaleProductPremiumFeatureQueue.WorkerID.Value != ParallelTaskWorker.ID) && (!_SaleProductPremiumFeatureQueue.LeaseExpiration.HasValue || !(_SaleProductPremiumFeatureQueue.LeaseExpiration.Value <= DateTime.Now)))
		{
			SaleProduct saleProduct = SaleProduct.Get(_SaleProductPremiumFeatureQueue.SaleProductID);
			if (saleProduct == null)
			{
				throw new ApplicationException($"No SaleProduct found for SaleProductPremiumFeatureQueue {_SaleProductPremiumFeatureQueue.ID}");
			}
			Account account = Account.Get(saleProduct.RecipientAccountID.Value);
			if (account == null)
			{
				throw new ApplicationException($"Account {saleProduct.RecipientAccountID.Value} not found for SaleProductPremiumFeatureQueue {_SaleProductPremiumFeatureQueue.ID}");
			}
			int premiumFeatureId = Product.Get(saleProduct.ProductID).PremiumFeatureID;
			_PremiumFeatureActivationTaskFactory.RequestPremiumFeatureActivation(account.ID, premiumFeatureId);
			_SaleProductPremiumFeatureQueue.PremiumFeatureGrantRequested = true;
			_SaleProductPremiumFeatureQueue.Save();
		}
	}
}
