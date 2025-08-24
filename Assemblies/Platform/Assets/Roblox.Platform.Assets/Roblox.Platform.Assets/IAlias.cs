using System;

namespace Roblox.Platform.Assets;

public interface IAlias
{
	INamespace Namespace { get; }

	string Name { get; }

	AliasType AliasType { get; }

	long TargetId { get; }

	void Update(string newName, AliasType newType, long newTarget);

	void Delete();

	[Obsolete("Use AliasType and TargetId")]
	object GetTarget();

	[Obsolete("Use Update()")]
	void Rename(string name);

	[Obsolete("Use Update()")]
	void Retarget(IAsset asset);

	[Obsolete("Use Update()")]
	void Retarget(IAssetVersion assetVersion);

	[Obsolete("Use AliasType and TargetId")]
	bool TryGetAsset(out IAsset asset);

	[Obsolete("Use AliasType and TargetId")]
	bool TryGetAssetVersion(out IAssetVersion assetVersion);
}
