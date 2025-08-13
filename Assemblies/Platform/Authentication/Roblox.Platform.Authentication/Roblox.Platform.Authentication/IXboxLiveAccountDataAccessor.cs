namespace Roblox.Platform.Authentication;

public interface IXboxLiveAccountDataAccessor
{
	void Save(IXboxLiveAccount account);

	void Delete(IXboxLiveAccount account);

	void LogXboxLiveAccountAction(long accountId, XboxLiveAccountActionType actionType, string xboxLivePairwiseId, string xboxLiveGamerTag);

	bool HasSetUsernamePassword(long accountId);

	bool HasHadLinkedAccount(long accountId);

	IXboxLiveAccount CreateNew(string xboxLivePairwiseId, string xboxLiveGamerTag, long accountId);

	IXboxLiveAccount Get(int id);

	IXboxLiveAccount GetByAccountId(long accountId);

	IXboxLiveAccount GetByXboxLivePairwiseId(string xboxLivePairwiseId);

	IXboxLiveAccount GetByXboxLiveGamerTag(string xboxLiveGamerTagHash);
}
