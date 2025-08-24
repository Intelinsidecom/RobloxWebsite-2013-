using System;
using System.Data.SqlClient;
using Roblox.Platform.Assets.Entities;

namespace Roblox.Platform.Assets;

internal class Alias : IAlias
{
	private readonly long _Id;

	private IAsset _Asset;

	private IAssetVersion _AssetVersion;

	public INamespace Namespace { get; private set; }

	public string Name { get; private set; }

	public AliasType AliasType { get; private set; }

	public long TargetId { get; private set; }

	internal Alias(INamespace ns, long id, string name, AliasType type, long targetId)
	{
		_Id = id;
		Namespace = ns;
		Name = name;
		AliasType = type;
		TargetId = targetId;
	}

	public void Update(string newName, AliasType newType, long newTargetId)
	{
		Name = newName;
		AliasType = newType;
		TargetId = newTargetId;
		Name nameEntity = GetNameEntity();
		string oldNameValue = nameEntity.NameValue;
		long oldAssetId = nameEntity.AssetID;
		int? oldAssetVersion = nameEntity.AssetVersion;
		byte? oldNameTypeId = nameEntity.NameTypeID;
		long? oldNameTargetId = nameEntity.NameTargetID;
		nameEntity.NameValue = newName;
		nameEntity.NameTypeID = (byte)newType;
		nameEntity.NameTargetID = newTargetId;
		if (AliasType == AliasType.Asset)
		{
			nameEntity.AssetID = TargetId;
			nameEntity.AssetVersion = null;
		}
		else if (AliasType == AliasType.AssetVersion)
		{
			IAssetVersion assetVersion = AssetVersionFactory.CheckedGet(newTargetId);
			nameEntity.AssetID = assetVersion.AssetId;
			nameEntity.AssetVersion = assetVersion.VersionNumber;
		}
		try
		{
			nameEntity.Save();
		}
		catch (SqlException ex)
		{
			if (ex.Number == 2601)
			{
				nameEntity.NameValue = oldNameValue;
				nameEntity.AssetID = oldAssetId;
				nameEntity.AssetVersion = oldAssetVersion;
				nameEntity.NameTypeID = oldNameTypeId;
				nameEntity.NameTargetID = oldNameTargetId;
				throw new DuplicateAliasException();
			}
			throw;
		}
	}

	private void Save()
	{
		long assetId = ((_Asset != null) ? _Asset.Id : _AssetVersion.AssetId);
		int? versionNumber = null;
		if (_AssetVersion != null)
		{
			versionNumber = _AssetVersion.VersionNumber;
		}
		Name nameEntity = GetNameEntity();
		nameEntity.NameValue = Name;
		nameEntity.AssetID = assetId;
		nameEntity.AssetVersion = versionNumber;
		nameEntity.Save();
	}

	private Name GetNameEntity()
	{
		return Roblox.Platform.Assets.Entities.Name.Get(_Id) ?? throw new UnknownAliasException(Namespace.Type, Namespace.TargetId, Name);
	}

	public void Delete()
	{
		GetNameEntity().Delete();
	}

	public object GetTarget()
	{
		if (_Asset == null)
		{
			return _AssetVersion;
		}
		return _Asset;
	}

	public void Rename(string name)
	{
		IAlias alias = Factories.AliasFactory.GetAlias(Namespace, name);
		if (alias != null && alias.Name != Name)
		{
			throw new DuplicateAliasException();
		}
		Name = name;
		Save();
	}

	public void Retarget(IAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentException("Required value not specified", "asset");
		}
		_Asset = asset;
		_AssetVersion = null;
		Save();
	}

	public void Retarget(IAssetVersion assetVersion)
	{
		if (assetVersion == null)
		{
			throw new ArgumentException("Required value not specified", "assetVersion");
		}
		_AssetVersion = assetVersion;
		_Asset = null;
		Save();
	}

	public bool TryGetAsset(out IAsset asset)
	{
		if (_Asset == null)
		{
			asset = null;
			return false;
		}
		asset = _Asset;
		return true;
	}

	public bool TryGetAssetVersion(out IAssetVersion assetVersion)
	{
		if (_AssetVersion == null)
		{
			assetVersion = null;
			return false;
		}
		assetVersion = _AssetVersion;
		return true;
	}
}
