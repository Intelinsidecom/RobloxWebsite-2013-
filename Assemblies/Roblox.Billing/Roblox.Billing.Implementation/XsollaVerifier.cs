using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Roblox.Billing.Interface;
using Roblox.Billing.Properties;

namespace Roblox.Billing.Implementation;

public class XsollaVerifier : IXsollaVerifier
{
	public virtual Func<string> XsollaSecretKey => () => Settings.Default.XsollaSecretKey;

	public bool IsUserValid(string xsollaUserId)
	{
		if (xsollaUserId == null)
		{
			return false;
		}
		long userId;
		try
		{
			userId = Convert.ToInt64(xsollaUserId);
		}
		catch (Exception)
		{
			return false;
		}
		return User.Get(userId) != null;
	}

	public bool IsPlanIdValid(string planId)
	{
		return Settings.Default.XsollaBcPlanId.Contains(planId);
	}

	public bool IsProductIdValid(int xsollaProductId)
	{
		return Product.Get(xsollaProductId) != null;
	}

	public bool IsRequestValid(string authorization, HttpContext context)
	{
		if (string.IsNullOrEmpty(authorization))
		{
			return false;
		}
		int signatureStart = authorization.IndexOf(" ");
		if (signatureStart < 0)
		{
			return false;
		}
		try
		{
			if (!string.IsNullOrEmpty(authorization))
			{
				string signature = authorization.Substring(signatureStart);
				string valueToHash = GetJsonRequestFromHeader(context) + XsollaSecretKey();
				return string.Equals(getSHA1Value(valueToHash.Trim()), signature.Trim());
			}
		}
		catch (Exception)
		{
			return false;
		}
		return false;
	}

	internal string GetJsonRequestFromHeader(HttpContext context)
	{
		string jsonRequest = string.Empty;
		context.Request.InputStream.Position = 0L;
		using StreamReader inputStream = new StreamReader(context.Request.InputStream);
		return inputStream.ReadToEnd();
	}

	internal virtual string getSHA1Value(string valueToHash)
	{
		byte[] array = new SHA1CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(valueToHash));
		StringBuilder sb = new StringBuilder(array.Length * 2);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			sb.Append(b.ToString("x2"));
		}
		return sb.ToString();
	}
}
