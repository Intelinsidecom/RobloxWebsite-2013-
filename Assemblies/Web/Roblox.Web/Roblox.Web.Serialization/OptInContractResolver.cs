using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Web.Properties;

namespace Roblox.Web.Serialization;

public class OptInContractResolver : DefaultContractResolver
{
	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly Func<bool> _Enabled;

	private static ConcurrentDictionary<OptInResolverCacheKey, JsonContract> _SharedContractCache = new ConcurrentDictionary<OptInResolverCacheKey, JsonContract>();

	public OptInContractResolver(ILogger logger, Func<bool> enabled)
	{
		_Logger = logger;
		_Settings = Settings.Default;
		_Enabled = enabled;
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.CustomJsonSerializationOptInContractResolverEnabled, ClearSharedCache);
	}

	/// <summary>
	/// Internal constructor used for testing.
	/// </summary>
	/// <param name="logger"></param>
	/// <param name="settings"></param>
	internal OptInContractResolver(ILogger logger, ISettings settings)
	{
		_Logger = logger;
		_Settings = settings;
		_Enabled = () => true;
	}

	/// <summary>
	/// Overrode this method because the created contract is always cached in the base class,
	/// but we want to repeatedly log errors for every violation.
	/// </summary>
	/// <param name="type"></param>
	/// <returns></returns>
	public override JsonContract ResolveContract(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		OptInResolverCacheKey key = new OptInResolverCacheKey(GetType(), type);
		if (!_SharedContractCache.TryGetValue(key, out var contract))
		{
			contract = CreateContract(type, out var optInPolicyFailure);
			if (!optInPolicyFailure)
			{
				_SharedContractCache.TryAdd(key, contract);
			}
		}
		return contract;
	}

	/// <summary>
	/// Overridden to prevent any type without a DataContract or JsonObject attribute from being serialized.
	/// </summary>
	/// <param name="objectType">Type of the object.</param>
	/// <param name="optInPolicyFailure">True if this model is an anonymous type or is missing serialization attributes.</param>
	/// <returns>A <see cref="T:Newtonsoft.Json.Serialization.JsonContract" /> for the given type.</returns>
	protected JsonContract CreateContract(Type objectType, out bool optInPolicyFailure)
	{
		JsonContract contract = base.CreateContract(objectType);
		optInPolicyFailure = false;
		if (_Settings.CustomJsonSerializationOptInContractResolverEnabled && _Enabled())
		{
			if (string.IsNullOrEmpty(objectType.Namespace))
			{
				optInPolicyFailure = true;
				if (_Settings.CustomJsonSerializationOptInContractResolverViolationThrowException)
				{
					throw new JsonSerializationException("Attempted to serialize anonymous type. Serialized type must be an object with correct serialization attributes.");
				}
				if (_Settings.CustomJsonSerializationOptInContractResolverViolationLogError)
				{
					_Logger.Error("Attempted to serialize object anonymous type. Serialized type must be an object with correct serialization attributes.");
				}
				if (!_Settings.CustomJsonSerializationOptInContractResolverSerializeUnmarkedObject)
				{
					return new JsonObjectContract(typeof(object));
				}
			}
			else if (objectType.Namespace != null && objectType.Namespace.Contains(_Settings.CustomJsonSerializationOptInContractResolverNamespaceRestriction) && objectType.CustomAttributes.All((CustomAttributeData a) => a.AttributeType != typeof(DataContractAttribute) && a.AttributeType != typeof(JsonObjectAttribute)))
			{
				optInPolicyFailure = true;
				if (_Settings.CustomJsonSerializationOptInContractResolverViolationThrowException)
				{
					throw new JsonSerializationException($"Attempted to serialize object {objectType.Namespace}.{objectType.Name} with no serialization attribute.");
				}
				if (_Settings.CustomJsonSerializationOptInContractResolverViolationLogError)
				{
					_Logger.Error($"Attempted to serialize object {objectType.Namespace}.{objectType.Name} with no serialization attribute.");
				}
				if (!_Settings.CustomJsonSerializationOptInContractResolverSerializeUnmarkedObject)
				{
					return new JsonObjectContract(typeof(object));
				}
			}
		}
		return contract;
	}

	/// <summary>
	/// Overridden to prevent any property without a DataMember or JsonProperty attribute from being serialized.
	/// </summary>
	/// <param name="memberSerialization">The member's parent <see cref="T:Newtonsoft.Json.MemberSerialization" />.</param>
	/// <param name="member">The member to create a <see cref="T:Newtonsoft.Json.Serialization.JsonProperty" /> for.</param>
	/// <returns>A created <see cref="T:Newtonsoft.Json.Serialization.JsonProperty" /> for the given <see cref="T:System.Reflection.MemberInfo" />.</returns>
	protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
	{
		JsonProperty property = base.CreateProperty(member, memberSerialization);
		if (_Settings.CustomJsonSerializationOptInContractResolverEnabled && _Enabled())
		{
			if (member.CustomAttributes.Any((CustomAttributeData a) => a.AttributeType == typeof(JsonPropertyAttribute) || a.AttributeType == typeof(DataMemberAttribute)))
			{
				property.ShouldSerialize = (object instance) => true;
			}
			else if (member.CustomAttributes.All((CustomAttributeData a) => a.AttributeType != typeof(JsonIgnoreAttribute) && a.AttributeType != typeof(ScriptIgnoreAttribute)))
			{
				if (_Settings.CustomJsonSerializationOptInContractResolverViolationThrowException)
				{
					throw new JsonSerializationException($"Attempted to serialize public property without proper attribute: property {member.Name} of {member.DeclaringType?.Namespace}.{member.DeclaringType?.Name}");
				}
				if (_Settings.CustomJsonSerializationOptInContractResolverViolationLogError)
				{
					_Logger.Error($"Attempted to serialize public property without proper attribute: property {member.Name} of {member.DeclaringType?.Namespace}.{member.DeclaringType?.Name}");
				}
				if (_Settings.CustomJsonSerializationOptInContractResolverUnmarkedProperty)
				{
					property.ShouldSerialize = (object instance) => true;
					property.Ignored = false;
				}
				else
				{
					property.ShouldSerialize = (object instance) => false;
				}
			}
		}
		return property;
	}

	internal static void ClearSharedCache()
	{
		_SharedContractCache = new ConcurrentDictionary<OptInResolverCacheKey, JsonContract>();
	}
}
