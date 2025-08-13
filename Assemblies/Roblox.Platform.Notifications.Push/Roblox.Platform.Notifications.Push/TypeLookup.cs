using System;
using System.Collections.Generic;
using Roblox.Entities;

namespace Roblox.Platform.Notifications.Push;

internal class TypeLookup<TEntity, TEnum> where TEntity : IEntity<int>
{
	private readonly Func<string, TEntity> _EntityGetter;

	private readonly Dictionary<TEnum, TEntity> _EnumToEntityMap = new Dictionary<TEnum, TEntity>();

	private readonly Dictionary<int, TEntity> _IdToEntityMap = new Dictionary<int, TEntity>();

	private readonly Dictionary<int, TEnum> _IdToEnumMap = new Dictionary<int, TEnum>();

	public TypeLookup(Func<string, TEntity> entityGetter)
	{
		_EntityGetter = entityGetter;
		foreach (object enumValue in Enum.GetValues(typeof(TEnum)))
		{
			Map((TEnum)enumValue);
		}
	}

	internal TEnum ToEnum(TEntity entity)
	{
		return _IdToEnumMap[entity.Id];
	}

	internal TEnum LookupEnum(int id)
	{
		return _IdToEnumMap[id];
	}

	internal TEntity ToEntity(TEnum enumValue)
	{
		return _EnumToEntityMap[enumValue];
	}

	internal TEntity Lookup(int id)
	{
		return _IdToEntityMap[id];
	}

	private void Map(TEnum enumValue)
	{
		TEntity entity = _EntityGetter(enumValue.ToString());
		_EnumToEntityMap[enumValue] = entity;
		_IdToEntityMap[entity.Id] = entity;
		_IdToEnumMap[entity.Id] = enumValue;
	}
}
