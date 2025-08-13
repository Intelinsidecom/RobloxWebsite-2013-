using System;
using Roblox.Captcha.Entities;
using Roblox.Common;
using Roblox.Platform.Captcha.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Represents a concrete implementation of the <see cref="T:Roblox.Platform.Captcha.IAction" /> interface.
/// </summary>
/// <example>
/// <code>
/// class ExampleClass
/// {
///     public static void Main(string[] args)
///     {
///         var identifier = new Identifier
///         {
///             TargetType = IdentifierTargetType.IpAddress;
///             Value = "192.169.0.1"
///         }
///
///         var factories = new Factories(SharedCacheWebClient.GetSingleton());
///
///         var action = new Action(identifier, ActionType.Signup, factories);
///
///         bool passed = action.HasPassed(DateTime.Now);
///         if (passed)
///         {
///             Console.WriteLine("IP address '192.168.0.1' has passed Captcha for Signup");
///             action.Invalidate();
///         }
///         else
///         {
///             Console.WriteLine("IP address '192.168.0.1' has NOT passed Captcha for Signup");
///         }
///     }
/// }
/// </code>
/// </example>
public class Action : IAction
{
	private Identifier _Identifer;

	private readonly ActionType _ActionType;

	private readonly Factories _Factories;

	protected virtual TimeSpan Expiration => Settings.Default.SuccessExpirationTime;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Captcha.Action" /> class.
	/// </summary>
	/// <param name="identifier">The <see cref="T:Roblox.Platform.Captcha.Identifier" /> of the target attempting to perform the <see cref="T:Roblox.Platform.Captcha.Action" />.</param>
	/// <param name="actionType">The type of action that is attempteing to be performed.</param>
	/// <param name="factories">The <see cref="T:Roblox.Platform.Captcha.Factories" /> container containing the needed factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="identifier" />'s 'Value' property is null.</exception>
	public Action(Identifier identifier, ActionType actionType, Factories factories)
	{
		if (identifier.Value == null)
		{
			throw new PlatformArgumentException("'Value' property of 'identifier' cannot be null.");
		}
		_Factories = factories ?? throw new PlatformArgumentNullException("factories");
		_Identifer = identifier;
		_ActionType = actionType;
	}

	/// <summary>
	/// Records that the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <see cref="T:Roblox.Platform.Captcha.IAction" /> could not be passed in its state.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation could not be performed.</exception>
	public void Pass(DateTime currentTime)
	{
		if (_Factories.SuccessFactory == null)
		{
			throw new PlatformOperationUnavailableException("Required SuccessFactory was null.");
		}
		try
		{
			_Factories.SuccessFactory.Get(_Identifer, _ActionType, Expiration)?.Delete();
		}
		catch (PlatformOperationUnavailableException e3)
		{
			throw new PlatformOperationUnavailableException("Failed to retrieve ISuccess from factory", e3);
		}
		ISuccess success = _Factories.SuccessFactory.Create(Expiration);
		success.ActionTypeId = (byte)_ActionType;
		success.Identifier = _Identifer.Serialize();
		success.TimeStamp = currentTime;
		try
		{
			success.Save();
		}
		catch (InvalidOperationException e2)
		{
			throw new PlatformInvalidOperationException("Failed to save ISuccess", e2);
		}
		catch (OperationUnavailableException e)
		{
			throw new PlatformOperationUnavailableException("Failed to save ISuccess", e);
		}
	}

	/// <summary>
	/// Determines whether or not the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation could not be performed.</exception>
	public bool HasPassed(DateTime currentTime)
	{
		if (_Factories.SuccessFactory == null)
		{
			throw new PlatformOperationUnavailableException("Required SuccessFactory was null.");
		}
		ISuccess success;
		try
		{
			success = _Factories.SuccessFactory.Get(_Identifer, _ActionType, Expiration);
		}
		catch (PlatformOperationUnavailableException e)
		{
			throw new PlatformOperationUnavailableException("Failed to get ISuccess from factory", e);
		}
		if (success == null)
		{
			return false;
		}
		return IsSuccessValid(success, currentTime);
	}

	/// <summary>
	/// Invalidates any record that the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation could not be performed.</exception>
	public void Invalidate()
	{
		if (_Factories.SuccessFactory == null)
		{
			throw new PlatformOperationUnavailableException("Required SuccessFactory was null.");
		}
		ISuccess success;
		try
		{
			success = _Factories.SuccessFactory.Get(_Identifer, _ActionType, Expiration);
		}
		catch (PlatformOperationUnavailableException e2)
		{
			throw new PlatformOperationUnavailableException("Failed to get ISuccess from factory", e2);
		}
		if (success != null)
		{
			try
			{
				success.Delete();
			}
			catch (OperationUnavailableException e)
			{
				throw new PlatformOperationUnavailableException("Failed to delete ISuccess", e);
			}
		}
	}

	/// <summary>
	/// Determines whether or not the given <see cref="T:Roblox.Captcha.Entities.ISuccess" /> is valid.
	/// </summary>
	/// <param name="success">The <see cref="T:Roblox.Captcha.Entities.ISuccess" /> to check for validity.</param>
	/// <param name="currentTime">The current time.</param>
	/// <returns>Whether or not <paramref name="success" /> is valid.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="success" /> is null.</exception>
	private bool IsSuccessValid(ISuccess success, DateTime currentTime)
	{
		if (success == null)
		{
			throw new PlatformArgumentNullException("success");
		}
		return currentTime - success.TimeStamp < Expiration;
	}
}
