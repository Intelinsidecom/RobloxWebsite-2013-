using System;
using System.Linq;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification;

namespace Roblox.Platform.Authentication.AccountSecurity;

public class AccountSecurityFactory : IAccountSecurityFactory, IDomainObject<AccountSecurityDomainFactories>
{
	private readonly string _AccountSecurityRevertAttemptCounter = "AccountSecurityRevert_Attempt";

	private readonly string _AccountSecurityRevertTicketV2NullFailureCounter = "AccountSecurityRevert_TicketV2NullFailure";

	private readonly string _AccountSecurityRevertTicketV1NullFailureCounter = "AccountSecurityRevert_TicketV1NullFailure";

	private readonly string _AccountSecurityRevertTargetUserNullFailureCounter = "AccountSecurityRevert_TargetUserNullFailure";

	private readonly string _AccountSecurityRevertTicketRetrievalFailureCounter = "AccountSecurityRevert_TicketRetrievalFailure";

	private readonly string _AccountSecurityRevertEmailInvalidFailureCounter = "AccountSecurityRevert_EmailInvalidFailure";

	private readonly string _AccountSecurityRevertEmailFailureCounter = "AccountSecurityRevert_EmailFailure";

	private readonly string _AccountSecurityRevertPhoneDeleteFailureCounter = "AccountSecurityRevert_PhoneDeleteFailure";

	private readonly string _AccountSecurityRevertPhoneFailureCounter = "AccountSecurityRevert_PhoneFailure";

	private readonly string _AccountSecurityRevertSuccessCounter = "AccountSecurityRevert_Success";

	public AccountSecurityDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="N:Roblox.Platform.Authentication.AccountSecurityTickets" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="domainFactories" />
	/// </exception>
	public AccountSecurityFactory(AccountSecurityDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	/// <summary>
	/// Creates AccountSecurityTicketItems linked to the supplied Guid 
	/// </summary>
	/// <param name="accountSecurityTicketsV2"><see cref="N:Roblox.Platform.Authentication.AccountSecurityTickets" /></param>
	/// <param name="accountSecurityTicket"><see cref="T:Roblox.AccountSecurityTicket" /></param>
	/// <param name="targetUser"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountSecurityTicketsV2" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountSecurityTicket" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="targetUser" /> is null.</exception>
	public void RevertAccountFromAccountSecurityTickets(Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets accountSecurityTicketsV2, AccountSecurityTicket accountSecurityTicket, IUser targetUser)
	{
		IncrementCounter(_AccountSecurityRevertAttemptCounter);
		if (accountSecurityTicketsV2 == null)
		{
			IncrementCounter(_AccountSecurityRevertTicketV2NullFailureCounter);
			throw new PlatformArgumentNullException("accountSecurityTicketsV2");
		}
		if (accountSecurityTicket == null)
		{
			IncrementCounter(_AccountSecurityRevertTicketV1NullFailureCounter);
			throw new PlatformArgumentNullException("accountSecurityTicket");
		}
		if (targetUser == null)
		{
			IncrementCounter(_AccountSecurityRevertTargetUserNullFailureCounter);
			throw new PlatformArgumentNullException("targetUser");
		}
		IAccountSecurityTicketItem[] accountSecurityTicketItems;
		try
		{
			accountSecurityTicketItems = DomainFactories.AccountSecurityTicketItemFactory.GetByAccountSecurityTicketsIdEnumerative(accountSecurityTicketsV2.Id).ToArray();
		}
		catch (Exception)
		{
			IncrementCounter(_AccountSecurityRevertTicketRetrievalFailureCounter);
			throw;
		}
		IAccountSecurityTicketItem emailTicket = accountSecurityTicketItems.FirstOrDefault((IAccountSecurityTicketItem ticket) => ticket.AccountSecurityTypeId == 1);
		if (emailTicket != null)
		{
			try
			{
				AccountEmailAddress.RevertAccountEmailAddress(AccountEmailAddress.Get((int)emailTicket.AccountSecurityTargetId));
				TwoStepVerificationSettingDTO twoStepSetting = DomainFactories.TwoStepVerificationConfigurationProvider.GetTwoStepSettingForUser(targetUser);
				if (!accountSecurityTicket.AccountEmailAddress.IsVerified && twoStepSetting != null && twoStepSetting.IsEnabled)
				{
					DomainFactories.TwoStepVerificationConfigurationProvider.SetTwoStepSettingForUser(targetUser, isEnabled: false);
				}
			}
			catch (ApplicationException)
			{
				IncrementCounter(_AccountSecurityRevertEmailInvalidFailureCounter);
				throw;
			}
			catch (Exception)
			{
				IncrementCounter(_AccountSecurityRevertEmailFailureCounter);
				throw;
			}
		}
		try
		{
			DomainFactories.AccountPhoneNumberFactory.DeletePhoneNumberForUser(targetUser, targetUser);
		}
		catch (Exception)
		{
			IncrementCounter(_AccountSecurityRevertPhoneDeleteFailureCounter);
			throw;
		}
		IAccountSecurityTicketItem phoneTicket = accountSecurityTicketItems.FirstOrDefault((IAccountSecurityTicketItem ticket) => ticket.AccountSecurityTypeId == 3);
		if (phoneTicket != null)
		{
			try
			{
				IPhoneNumber phoneNumber = DomainFactories.PhoneNumberFactory.Get(new PhoneNumberIdentifier((int)phoneTicket.AccountSecurityTargetId));
				DomainFactories.AccountPhoneNumberFactory.AddUnverifiedForUser(targetUser, phoneNumber, targetUser).SetToVerified(targetUser, targetUser);
			}
			catch (Exception)
			{
				IncrementCounter(_AccountSecurityRevertPhoneFailureCounter);
				throw;
			}
		}
		IncrementCounter(_AccountSecurityRevertSuccessCounter);
	}

	private void IncrementCounter(string counter)
	{
		DomainFactories.EphemeralCounterFactory.GetCounter(counter).IncrementInBackground();
	}
}
