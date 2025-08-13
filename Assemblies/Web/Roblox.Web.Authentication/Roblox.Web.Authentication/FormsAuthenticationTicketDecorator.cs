using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;

namespace Roblox.Web.Authentication;

internal class FormsAuthenticationTicketDecorator
{
	private FormsAuthenticationTicket _Ticket;

	private Dictionary<string, string> _UserData;

	private bool _NeedsSerialization;

	private DateTime _Expiration;

	public FormsAuthenticationTicket Ticket
	{
		get
		{
			if (_NeedsSerialization)
			{
				string serializeUserData = SerializeUserData();
				_Ticket = new FormsAuthenticationTicket(_Ticket.Version, _Ticket.Name, _Ticket.IssueDate, _Expiration, _Ticket.IsPersistent, serializeUserData);
			}
			return _Ticket;
		}
	}

	public DateTime Expiration
	{
		get
		{
			return _Expiration;
		}
		set
		{
			_Expiration = value;
			_NeedsSerialization = true;
		}
	}

	public DateTime IssueDate => _Ticket.IssueDate;

	public FormsAuthenticationTicketDecorator(FormsAuthenticationTicket ticket)
	{
		_Ticket = ticket;
		_Expiration = ticket.Expiration;
		DeserializeUserData(ticket.UserData);
		_NeedsSerialization = false;
	}

	private string SerializeUserData()
	{
		IEnumerable<string> keyValues = _UserData.Keys.Select((string key) => key + "=" + _UserData[key]);
		return string.Join("&", keyValues);
	}

	private void DeserializeUserData(string serializedUserData)
	{
		_UserData = new Dictionary<string, string>();
		string[] array = serializedUserData.Split('&');
		for (int i = 0; i < array.Length; i++)
		{
			string[] keyValuePair = array[i].Split('=');
			if (keyValuePair.Length == 2)
			{
				_UserData[keyValuePair[0]] = keyValuePair[1];
			}
		}
	}

	public string GetUserData(string key)
	{
		_UserData.TryGetValue(key, out var value);
		return value;
	}

	public void SetUserData(string key, string value)
	{
		_UserData[key] = value;
		_NeedsSerialization = true;
	}
}
