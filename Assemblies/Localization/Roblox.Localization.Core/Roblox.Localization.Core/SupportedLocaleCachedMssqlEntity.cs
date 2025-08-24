using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class SupportedLocaleCachedMssqlEntity : ISupportedLocaleEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Locale { get; set; }

	public string Name { get; set; }

	public string NativeName { get; set; }

	public int LanguageId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		SupportedLocale cal = SupportedLocale.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Locale = Locale;
		cal.Name = Name;
		cal.NativeName = NativeName;
		cal.LanguageID = LanguageId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(SupportedLocale.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
