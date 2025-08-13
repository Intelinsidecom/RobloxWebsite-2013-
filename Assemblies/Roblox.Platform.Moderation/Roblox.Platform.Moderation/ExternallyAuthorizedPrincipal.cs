namespace Roblox.Platform.Moderation;

public class ExternallyAuthorizedPrincipal<TId> : IExternallyAuthorizedPrincipal<TId> where TId : struct
{
	public AuthorizingParty AuthorizingParty { get; }

	public TId Id { get; }

	public ExternallyAuthorizedOperation ExternallyAuthorizedOperation { get; }

	public ExternallyAuthorizedPrincipal(AuthorizingParty authorizingParty, TId id, ExternallyAuthorizedOperation externallyAuthorizedOperation)
	{
		AuthorizingParty = authorizingParty;
		Id = id;
		ExternallyAuthorizedOperation = externallyAuthorizedOperation;
	}
}
