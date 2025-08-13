using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Configuration;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Sms.Client;
using Roblox.Web.ElevatedActions.Base;
using Roblox.Web.ElevatedActions.BLL;
using Roblox.Web.ElevatedActions.Properties;

namespace Roblox.Web.ElevatedActions;

public class ElevatedActionAlert
{
	private readonly Func<ElevatedAction> _ElevatedActionAccessor;

	private readonly Action<Exception> _ExceptionLogger;

	private readonly IUserFactory _UserFactory;

	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly ISmsClient _SmsClient;

	private const int _MaximumAccountsInARoleSet = 10000;

	private readonly IEmailSender _EmailSender;

	private const string _EmailType = "ElevatedActionAlert";

	protected HashSet<string> ElevatedActionsWhichTriggerEmail => MultiValueSettingParser.ParseCommaDelimitedListString(Settings.Default.ElevatedActionsWhichTriggerEmail);

	protected IReadOnlyCollection<string> RoleSetsWhichReceiveEmail => MultiValueSettingParser.ParseCommaDelimitedListStringMaintainOrdering(Settings.Default.RoleSetsWhichReceiveEmail);

	protected IReadOnlyCollection<string> AddressesWhichReceiveEmail => MultiValueSettingParser.ParseCommaDelimitedListStringMaintainOrdering(Settings.Default.AddressesWhichReceiveEmail);

	protected HashSet<string> ElevatedActionsWhichTriggerSMS => MultiValueSettingParser.ParseCommaDelimitedListString(Settings.Default.ElevatedActionsWhichTriggerSMS);

	protected IReadOnlyCollection<string> RoleSetsWhichReceiveSMS => MultiValueSettingParser.ParseCommaDelimitedListStringMaintainOrdering(Settings.Default.RoleSetsWhichReceiveSMS);

	protected IReadOnlyCollection<string> NumbersWhichReceiveSMS => MultiValueSettingParser.ParseCommaDelimitedListStringMaintainOrdering(Settings.Default.NumbersWhichReceiveSMS);

	public ElevatedActionAlert(Func<ElevatedAction> elevatedActionAccessor, Action<Exception> exceptionLogger, IElevatedActionFactories elevatedActionFactories)
	{
		_ElevatedActionAccessor = elevatedActionAccessor;
		_ExceptionLogger = exceptionLogger;
		_AccountPhoneNumberFactory = elevatedActionFactories.AccountPhoneNumberFactory;
		_UserFactory = elevatedActionFactories.UserFactory;
		_EmailSender = elevatedActionFactories.EmailSender;
		_SmsClient = elevatedActionFactories.SmsClient;
	}

	public void Send(Account actionPerformer, string actionDisplayName, string actionDetailedDescription)
	{
		Send(actionPerformer.Name, actionDisplayName, actionDetailedDescription);
	}

	public void Send(string actionPerformerName, string actionDisplayName, string actionDetailedDescription)
	{
		string actionName = ActionName();
		if (ElevatedActionsWhichTriggerEmail.Contains(actionName))
		{
			try
			{
				SendEmail(actionPerformerName, actionDisplayName, actionDetailedDescription);
			}
			catch (Exception exception2)
			{
				_ExceptionLogger(exception2);
			}
		}
		if (ElevatedActionsWhichTriggerSMS.Contains(actionName))
		{
			try
			{
				SendSMS(actionPerformerName, actionDisplayName);
			}
			catch (Exception exception)
			{
				_ExceptionLogger(exception);
			}
		}
	}

	private string ActionName()
	{
		return _ElevatedActionAccessor().Name;
	}

	private void SendSMS(string actionPerformerName, string actionDisplayName)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		string message = BuildSubject(actionPerformerName, actionDisplayName);
		foreach (long accountId in GetAccountIdsInRoles(RoleSetsWhichReceiveSMS))
		{
			try
			{
				IUser user = _UserFactory.GetUserByAccountId(accountId);
				IAccountPhoneNumber accountPhoneNumber = _AccountPhoneNumberFactory.GetVerifiedForUser(user);
				if (accountPhoneNumber != null)
				{
					Sms sms2 = new Sms(accountPhoneNumber.FullPhoneNumber, message);
					_SmsClient.Send(sms2);
				}
			}
			catch (Exception exception2)
			{
				_ExceptionLogger(exception2);
			}
		}
		foreach (string number in NumbersWhichReceiveSMS)
		{
			try
			{
				Sms sms = new Sms(number, message);
				_SmsClient.Send(sms);
			}
			catch (Exception exception)
			{
				_ExceptionLogger(exception);
			}
		}
	}

	private void SendEmail(string actionPerformerName, string actionDisplayName, string actionDetailedDescription)
	{
		string subject = BuildSubject(actionPerformerName, actionDisplayName);
		string body = $"{subject}{Environment.NewLine}{BuildBody(actionDetailedDescription)}";
		List<string> recipients = AddressesWhichReceiveEmail.ToList();
		foreach (long accountId in GetAccountIdsInRoles(RoleSetsWhichReceiveSMS))
		{
			try
			{
				AccountEmailAddress accountEmailAddress = AccountEmailAddress.GetCurrent(accountId);
				if (accountEmailAddress != null)
				{
					EmailAddress emailAddress = EmailAddress.Get(accountEmailAddress.EmailAddressID);
					if (emailAddress != null)
					{
						recipients.Add(emailAddress.Address);
					}
				}
			}
			catch (Exception exception)
			{
				_ExceptionLogger(exception);
			}
		}
		if (recipients.Any())
		{
			Email email = new Email("\"ROBLOX Elevated Action Alerts\" <no-reply@roblox.com>", string.Join(",", recipients), subject, EmailBodyType.Plain, "ElevatedActionAlert", body);
			_EmailSender.SendEmail(email);
		}
	}

	private string BuildSubject(string actionPerformerName, string actionDisplayName)
	{
		return $"{actionDisplayName} performed by {actionPerformerName} on {RobloxEnvironment.Name} at {DateTime.Now:s}.";
	}

	private string BuildBody(string description)
	{
		return description;
	}

	private ICollection<long> GetAccountIdsInRoles(IReadOnlyCollection<string> roleNames)
	{
		HashSet<long> accountIds = new HashSet<long>();
		try
		{
			foreach (string roleName in roleNames)
			{
				RoleSet role = RoleSet.GetByName(roleName);
				if (role != null)
				{
					AccountRoleSet.GetAllAccountRoleSetsByRoleSetID(role.ID, 10000).ToList().ForEach(delegate(AccountRoleSet ars)
					{
						accountIds.Add(ars.AccountID);
					});
				}
			}
		}
		catch (Exception exception)
		{
			_ExceptionLogger(exception);
		}
		return accountIds.ToList();
	}
}
