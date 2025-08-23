using System;

namespace Roblox.Web.Serialization;

/// <summary>
/// Class pulled from NUnit used by the ContractResolver to cache
/// contracts for created types
/// </summary>
internal struct OptInResolverCacheKey : IEquatable<OptInResolverCacheKey>
{
	private readonly Type _ResolverType;

	private readonly Type _ContractType;

	public OptInResolverCacheKey(Type resolverType, Type contractType)
	{
		_ResolverType = resolverType;
		_ContractType = contractType;
	}

	public override int GetHashCode()
	{
		return _ResolverType.GetHashCode() ^ _ContractType.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is OptInResolverCacheKey))
		{
			return false;
		}
		return Equals((OptInResolverCacheKey)obj);
	}

	public bool Equals(OptInResolverCacheKey other)
	{
		if (_ResolverType == other._ResolverType)
		{
			return _ContractType == other._ContractType;
		}
		return false;
	}
}
