namespace Roblox.Moderation;

public class GenericAccountStatus : IAccountStatus
{
	public byte ID { get; private set; }

	public GenericAccountStatus(byte id)
	{
		ID = id;
	}
}
