using System;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Moderation.Entities;
using Roblox.Platform.Moderation.Factories;

namespace Roblox.Platform.Moderation;

/// <summary>
/// The domain factories class for holding reference of all factory objects needed for Platform.Moderation.
/// </summary>
public class ModerationDomainFactories : DomainFactoriesBase
{
	internal virtual IModerationLocaleEntityFactory ModerationLocaleEntityFactory { get; }

	internal virtual IExpressionEntityFactory ExpressionEntityFactory { get; }

	/// <summary>
	/// <see cref="T:Roblox.Platform.Moderation.IExpressionFactory" />
	/// </summary>
	public virtual IExpressionFactory ExpressionFactory { get; }

	/// <summary>
	/// <see cref="T:Roblox.Platform.Moderation.IExpressionFactory" />
	/// </summary>
	public virtual IModerationLocaleFactory ModerationLocaleFactory { get; }

	/// <summary>
	/// Default constructor for <see cref="T:Roblox.Platform.Moderation.ModerationDomainFactories" />
	/// </summary>
	public ModerationDomainFactories(ICoreLocalizationAccessor coreLocalizationAccessor)
	{
		if (coreLocalizationAccessor == null)
		{
			throw new ArgumentNullException("coreLocalizationAccessor");
		}
		ModerationLocaleEntityFactory = new ModerationLocaleEntityFactory(this);
		ExpressionEntityFactory = new ExpressionEntityFactory();
		ExpressionFactory = new ExpressionFactory(this);
		ModerationLocaleFactory = new ModerationLocaleFactory(this, coreLocalizationAccessor);
	}
}
