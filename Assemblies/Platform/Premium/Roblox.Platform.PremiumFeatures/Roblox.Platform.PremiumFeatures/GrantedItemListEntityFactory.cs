using System.Diagnostics.CodeAnalysis;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
public class GrantedItemListEntityFactory : IGrantedItemListEntityFactory
{
	public IGrantedItemListEntity Get(long id)
	{
		return CalToCachedMssql(GrantedItemListEntity.Get(id));
	}

	public IGrantedItemListEntity Create(string name)
	{
		GrantedItemListEntity grantedItemListEntity = new GrantedItemListEntity();
		grantedItemListEntity.Name = name;
		grantedItemListEntity.Save();
		return CalToCachedMssql(grantedItemListEntity);
	}

	private static IGrantedItemListEntity CalToCachedMssql(GrantedItemListEntity cal)
	{
		if (cal != null)
		{
			return new GrantedItemListCachedMssqlEntity
			{
				Id = cal.ID,
				Name = cal.Name,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
