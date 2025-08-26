namespace Roblox.Localization.Accountsinternal {
    class AccountLocalesChangeAgent : IAccountLocalesChangeAgent

{
	public AccountLocalesChangeAgentType ChangeAgentType { get; }

	public long ChangeAgentTargetId { get; }

	public AccountLocalesChangeAgent(AccountLocalesChangeAgentType changeAgentType, long changeAgentTargetId)
	{
		ChangeAgentType = changeAgentType;
		ChangeAgentTargetId = changeAgentTargetId;
	}
}


}
