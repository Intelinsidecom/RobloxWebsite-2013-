namespace Roblox.Platform.Assets;

public class LuaFactory : AssetFactoryBase<ILua>
{
	protected override int AssetTypeId => Roblox.AssetType.LuaID;

	internal LuaFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ILua BuildChildAsset(IAsset genericAsset)
	{
		return new Lua(base.DomainFactories, genericAsset);
	}

	internal ILua GetLua(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
