using Roblox.Platform.Core;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// Represents an object that contains factories for the Xbox domain.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.DomainFactoriesBase" />
public class XboxDomainFactories : DomainFactoriesBase
{
	internal virtual ICrossPlaySettingEntityFactory CrossPlaySettingEntityFactory { get; }

	/// <summary>
	/// Gets the cross play setting factory.
	/// </summary>
	/// <value>
	/// The cross play setting factory.
	/// </value>
	public virtual ICrossPlaySettingFactory CrossPlaySettingFactory { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.XboxLive.IXboxSoothsayerVerifier" />
	/// </summary>
	public virtual IXboxSoothsayerVerifier XboxSoothsayerVerifier { get; }

	/// <summary>
	/// XboxDomainFactories is the new Domain factory for all Roblox.Platform.XboxLive. 
	/// Currently most of the entities that the factory should build still reside in Roblox.Platform.XboxLive.Entities 
	/// </summary>
	public XboxDomainFactories()
	{
		CrossPlaySettingEntityFactory = new CrossPlaySettingEntityFactory(this);
		CrossPlaySettingFactory = new CrossPlaySettingFactory(this);
		XboxSoothsayerVerifier = new XboxSoothsayerVerifier();
	}
}
