namespace Roblox.Localization.Accountsinternal {
    class AccountCountriesChangeAgent : IAccountCountriesChangeAgent

{
	public AccountCountriesChangeAgentType ChangeAgentType { get; }

	public long ChangeAgentTargetId { get; }

	public AccountCountriesChangeAgent(AccountCountriesChangeAgentType changeAgentType, long changeAgentTargetId)
	{
		ChangeAgentType = changeAgentType;
		ChangeAgentTargetId = changeAgentTargetId;
	}
}


}
