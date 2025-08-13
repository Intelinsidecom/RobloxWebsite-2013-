using System;
using Roblox.Paging;

namespace Roblox.Platform.Assets;

public interface IAliasFactory
{
	string GetDefaultAliasForDeveloperProductName(string entityName);

	INamespace GetUniverseNamespace(long universeId);

	[Obsolete("Use CreateAlias(INamespace, string name, AliasType, long id)")]
	IAlias Create(INamespace ns, string name, IAsset asset);

	[Obsolete("Use CreateAlias(INamespace, string name, AliasType, long id)")]
	IAlias Create(INamespace ns, string name, IAssetVersion assetVersion);

	IAlias CreateAlias(INamespace ns, string name, AliasType type, long targetId);

	IAlias GetAlias(INamespace ns, string name);

	IPagedResult<int, IAlias> GetAliases(INamespace ns, int offset, int count);
}
