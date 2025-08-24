using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class LanguageDefaultSupportedLocaleCachedMssqlEntity : ILanguageDefaultSupportedLocaleEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public int LanguageId { get; set; }

	public int SupportedLocaleId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		LanguageDefaultSupportedLocale cal = LanguageDefaultSupportedLocale.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.LanguageID = LanguageId;
		cal.SupportedLocaleID = SupportedLocaleId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(LanguageDefaultSupportedLocale.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
