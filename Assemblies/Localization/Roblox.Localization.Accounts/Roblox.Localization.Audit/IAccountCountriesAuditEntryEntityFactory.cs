using System;
using System.Collections.Generic;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountCountriesAuditEntryEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" /> with the given ID, or null if none existed.</returns>
	IAccountCountriesAuditEntryEntity GetById(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" /> with the given PublicId.
	/// </summary>
	/// <param name="publicId">The PublicId.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" /> with the given PublicId, or null if none existed.</returns>
	IAccountCountriesAuditEntryEntity GetByPublicId(Guid publicId);

	/// <summary>
	/// Gets individual <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" /> by thier PublicIds and returns them in a <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" />.
	/// </summary>
	/// <param name="publicIds">The publicIds.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" />.</returns>
	IReadOnlyCollection<IAccountCountriesAuditEntryEntity> SingleGetsByPublicIds(IEnumerable<Guid> publicIds);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" />s by their AuditId.
	/// </summary>
	/// <param name="auditId">The AuditId.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" />s.</returns>
	IReadOnlyCollection<IAccountCountriesAuditEntryEntity> GetByAuditIdEnumerative(long auditId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates a new audit entry record based on the given <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountryEntity" />.
	/// </summary>
	/// <param name="entity">The entity to base the audit on.</param>
	/// <returns>The newly created <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" />.</returns>
	IAccountCountriesAuditEntryEntity Create(IAccountCountryEntity entity);
}
