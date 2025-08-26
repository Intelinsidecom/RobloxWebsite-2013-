namespace Roblox.Moderation.Interfacespublic {
    interface IWhitelistEntry

{
	CategoryType CategoryType { get; }

	long CategoryTargetId { get; }

	string Value { get; }

	void Delete();

	void Update(string categoryType, long categoryTargetId, string value);
}


}
