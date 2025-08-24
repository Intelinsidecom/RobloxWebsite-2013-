using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class LanguageCachedMssqlEntity : ILanguageEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string NativeName { get; set; }

	public string LanguageCode { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		Language cal = Language.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Name = Name;
		cal.NativeName = NativeName;
		cal.LanguageCode = LanguageCode;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(Language.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
