using System;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServer : IPrivateServer
{
	public long Id { get; private set; }

	public long UniverseId { get; private set; }

	public string Name { get; set; }

	public long OwnerUserId { get; private set; }

	public PrivateServerStatusType StatusType { get; set; }

	public Guid AccessCode { get; private set; }

	public DateTime ExpirationDate { get; set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	public string LinkCode { get; set; }

	public PrivateServer(long id, long universeId, string name, long ownerUserId, byte statusTypeId, Guid accessCode, DateTime expirationDate, DateTime created, DateTime updated, string linkCode)
	{
		Id = id;
		UniverseId = universeId;
		Name = name;
		OwnerUserId = ownerUserId;
		StatusType = (PrivateServerStatusType)statusTypeId;
		AccessCode = accessCode;
		ExpirationDate = expirationDate;
		Created = created;
		Updated = updated;
		LinkCode = linkCode;
	}
}
