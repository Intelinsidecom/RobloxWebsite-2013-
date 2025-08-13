using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class ObservedLocaleCachedMssqlEntity : IObservedLocaleEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Locale { get; set; }

	public int? LanguageId { get; set; }

	public int? SupportedLocaleId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		ObservedLocale cal = ObservedLocale.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Locale = Locale;
		cal.LanguageID = LanguageId;
		cal.SupportedLocaleID = SupportedLocaleId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(ObservedLocale.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
