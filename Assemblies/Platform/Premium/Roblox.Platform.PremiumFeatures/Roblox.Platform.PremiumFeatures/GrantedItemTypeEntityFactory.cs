using System.Diagnostics.CodeAnalysis;
using Roblox.Data;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
public class GrantedItemTypeEntityFactory : IGrantedItemTypeEntityFactory
{
	public IGrantedItemTypeEntity Asset => MustGetByValue("Asset");

	public IGrantedItemTypeEntity Bundle => MustGetByValue("Bundle");

	public IGrantedItemTypeEntity Get(byte id)
	{
		return CalToCachedMssql(GrantedItemTypeEntity.Get(id));
	}

	public IGrantedItemTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(GrantedItemTypeEntity.GetByValue(value));
	}

	private IGrantedItemTypeEntity MustGetByValue(string value)
	{
		return GetByValue(value) ?? throw new DataIntegrityException($"GrantedItemType with value '{value}' not found");
	}

	private static IGrantedItemTypeEntity CalToCachedMssql(GrantedItemTypeEntity cal)
	{
		if (cal != null)
		{
			return new GrantedItemTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
