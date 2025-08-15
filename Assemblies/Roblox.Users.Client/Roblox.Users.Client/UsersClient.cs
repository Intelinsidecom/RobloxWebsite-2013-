using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.RequestContext;
using Roblox.Users.Client.Properties;

namespace Roblox.Users.Client;

public class UsersClient : IUsersClient
{
	private readonly IServiceRequestSender _ServiceRequestSender;

	public UsersClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader = null)
		: this(CreateHttpClientBuilder(counterRegistry, apiKeyGetter, requestContextLoader), Settings.Default)
	{
	}

	public UsersClient(IHttpClientBuilder httpClientBuilder, IServiceClientSettings serviceClientSettings)
	{
		if (httpClientBuilder == null)
		{
			throw new ArgumentNullException("httpClientBuilder");
		}
		if (serviceClientSettings == null)
		{
			throw new ArgumentNullException("serviceClientSettings");
		}
		IHttpClient httpClient = httpClientBuilder.Build();
		HttpRequestBuilder httpRequestBuilder = new HttpRequestBuilder(serviceClientSettings.Endpoint);
		_ServiceRequestSender = new ServiceRequestSender(httpClient, httpRequestBuilder);
	}

	public bool AcquirePlaceholderUsername(long accountId, string name)
	{
		AcquirePlaceholderUsernameRequest requestData = new AcquirePlaceholderUsernameRequest
		{
			AccountId = accountId,
			Name = name
		};
		return _ServiceRequestSender.SendPostRequest<AcquirePlaceholderUsernameRequest, bool>("/v1/AcquirePlaceholderUsername", requestData);
	}

	public Task<bool> AcquirePlaceholderUsernameAsync(long accountId, string name, CancellationToken cancellationToken)
	{
		AcquirePlaceholderUsernameRequest requestData = new AcquirePlaceholderUsernameRequest
		{
			AccountId = accountId,
			Name = name
		};
		return _ServiceRequestSender.SendPostRequestAsync<AcquirePlaceholderUsernameRequest, bool>("/v1/AcquirePlaceholderUsername", requestData, cancellationToken);
	}

	public bool HasActivePlaceholderUsername(long accountId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = accountId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, bool>("/v1/HasActivePlaceholderUsername", requestData);
	}

	public Task<bool> HasActivePlaceholderUsernameAsync(long accountId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = accountId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, bool>("/v1/HasActivePlaceholderUsername", requestData, cancellationToken);
	}

	public bool ReleasePlaceholderUsername(long accountId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = accountId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, bool>("/v1/ReleasePlaceholderUsername", requestData);
	}

	public Task<bool> ReleasePlaceholderUsernameAsync(long accountId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = accountId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, bool>("/v1/ReleasePlaceholderUsername", requestData, cancellationToken);
	}

	public AccountStatusEntity[] GetModerationStatuses()
	{
		EmptyRequest requestData = new EmptyRequest();
		return _ServiceRequestSender.SendPostRequest<EmptyRequest, AccountStatusEntity[]>("/v1/GetModerationStatuses", requestData);
	}

	public Task<AccountStatusEntity[]> GetModerationStatusesAsync(CancellationToken cancellationToken)
	{
		EmptyRequest requestData = new EmptyRequest();
		return _ServiceRequestSender.SendPostRequestAsync<EmptyRequest, AccountStatusEntity[]>("/v1/GetModerationStatuses", requestData, cancellationToken);
	}

	public IReadOnlyCollection<GenderTypeEntity> GetGenders()
	{
		EmptyRequest requestData = new EmptyRequest();
		return _ServiceRequestSender.SendPostRequest<EmptyRequest, IReadOnlyCollection<GenderTypeEntity>>("/v1/GetGenders", requestData);
	}

	public Task<IReadOnlyCollection<GenderTypeEntity>> GetGendersAsync(CancellationToken cancellationToken)
	{
		EmptyRequest requestData = new EmptyRequest();
		return _ServiceRequestSender.SendPostRequestAsync<EmptyRequest, IReadOnlyCollection<GenderTypeEntity>>("/v1/GetGenders", requestData, cancellationToken);
	}

	public AgentData GetAgentByAgentId(long agentId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = agentId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, AgentData>("/v1/GetAgentByAgentId", requestData);
	}

	public Task<AgentData> GetAgentByAgentIdAsync(long agentId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = agentId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, AgentData>("/v1/GetAgentByAgentId", requestData, cancellationToken);
	}

	public long? GetAgentIdByTypeAndTargetId(AssociatedEntityType type, long targetId)
	{
		GetAgentIdByTypeAndTargetIdRequest requestData = new GetAgentIdByTypeAndTargetIdRequest
		{
			Type = type,
			TargetId = targetId
		};
		return _ServiceRequestSender.SendPostRequest<GetAgentIdByTypeAndTargetIdRequest, long?>("/v1/GetAgentIdByTypeAndTargetId", requestData);
	}

	public Task<long?> GetAgentIdByTypeAndTargetIdAsync(AssociatedEntityType type, long targetId, CancellationToken cancellationToken)
	{
		GetAgentIdByTypeAndTargetIdRequest requestData = new GetAgentIdByTypeAndTargetIdRequest
		{
			Type = type,
			TargetId = targetId
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetAgentIdByTypeAndTargetIdRequest, long?>("/v1/GetAgentIdByTypeAndTargetId", requestData, cancellationToken);
	}

	public ChangeUsernameResult ChangeUsername(long userId, string currentName, string newName, bool recordHistory)
	{
		ChangeUsernameRequest requestData = new ChangeUsernameRequest
		{
			UserId = userId,
			CurrentName = currentName,
			NewName = newName,
			RecordHistory = recordHistory
		};
		return _ServiceRequestSender.SendPostRequest<ChangeUsernameRequest, ChangeUsernameResult>("/v1/ChangeUsername", requestData);
	}

	public Task<ChangeUsernameResult> ChangeUsernameAsync(long userId, string currentName, string newName, bool recordHistory, CancellationToken cancellationToken)
	{
		ChangeUsernameRequest requestData = new ChangeUsernameRequest
		{
			UserId = userId,
			CurrentName = currentName,
			NewName = newName,
			RecordHistory = recordHistory
		};
		return _ServiceRequestSender.SendPostRequestAsync<ChangeUsernameRequest, ChangeUsernameResult>("/v1/ChangeUsername", requestData, cancellationToken);
	}

	public int DeleteUsername(long userId, string name)
	{
		DeleteUsernameRequest requestData = new DeleteUsernameRequest
		{
			UserId = userId,
			Name = name
		};
		return _ServiceRequestSender.SendPostRequest<DeleteUsernameRequest, int>("/v1/DeleteUsername", requestData);
	}

	public Task<int> DeleteUsernameAsync(long userId, string name, CancellationToken cancellationToken)
	{
		DeleteUsernameRequest requestData = new DeleteUsernameRequest
		{
			UserId = userId,
			Name = name
		};
		return _ServiceRequestSender.SendPostRequestAsync<DeleteUsernameRequest, int>("/v1/DeleteUsername", requestData, cancellationToken);
	}

	public HistoricalUsername[] GetUsernameHistoryByUserId(long userId, int count, SortOrder sortOrder, long? exclusiveStartId)
	{
		GetUsernameHistoryByUserIdRequest requestData = new GetUsernameHistoryByUserIdRequest
		{
			UserId = userId,
			Count = count,
			SortOrder = sortOrder,
			ExclusiveStartId = exclusiveStartId
		};
		return _ServiceRequestSender.SendPostRequest<GetUsernameHistoryByUserIdRequest, HistoricalUsername[]>("/v1/GetUsernameHistoryByUserId", requestData);
	}

	public Task<HistoricalUsername[]> GetUsernameHistoryByUserIdAsync(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, CancellationToken cancellationToken)
	{
		GetUsernameHistoryByUserIdRequest requestData = new GetUsernameHistoryByUserIdRequest
		{
			UserId = userId,
			Count = count,
			SortOrder = sortOrder,
			ExclusiveStartId = exclusiveStartId
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetUsernameHistoryByUserIdRequest, HistoricalUsername[]>("/v1/GetUsernameHistoryByUserId", requestData, cancellationToken);
	}

	public bool IsUsernameAvailable(string username)
	{
		Payload<string> requestData = new Payload<string>
		{
			Data = username
		};
		return _ServiceRequestSender.SendPostRequest<Payload<string>, bool>("/v1/IsUsernameAvailable", requestData);
	}

	public Task<bool> IsUsernameAvailableAsync(string username, CancellationToken cancellationToken)
	{
		Payload<string> requestData = new Payload<string>
		{
			Data = username
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<string>, bool>("/v1/IsUsernameAvailable", requestData, cancellationToken);
	}

	public UserData GetUserByName(string name, bool includeUsernameHistory)
	{
		GetUserByNameRequest requestData = new GetUserByNameRequest
		{
			Name = name,
			IncludeUsernameHistory = includeUsernameHistory
		};
		return _ServiceRequestSender.SendPostRequest<GetUserByNameRequest, UserData>("/v1/GetUserByName", requestData);
	}

	public Task<UserData> GetUserByNameAsync(string name, bool includeUsernameHistory, CancellationToken cancellationToken)
	{
		GetUserByNameRequest requestData = new GetUserByNameRequest
		{
			Name = name,
			IncludeUsernameHistory = includeUsernameHistory
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetUserByNameRequest, UserData>("/v1/GetUserByName", requestData, cancellationToken);
	}

	public IDictionary<string, UserData> MultiGetUsersByNames(ISet<string> names, bool includeUsernameHistory)
	{
		MultiGetUsersByNamesRequest requestData = new MultiGetUsersByNamesRequest
		{
			Names = names,
			IncludeUsernameHistory = includeUsernameHistory
		};
		return _ServiceRequestSender.SendPostRequest<MultiGetUsersByNamesRequest, IDictionary<string, UserData>>("/v1/MultiGetUsersByNames", requestData);
	}

	public Task<IDictionary<string, UserData>> MultiGetUsersByNamesAsync(ISet<string> names, bool includeUsernameHistory, CancellationToken cancellationToken)
	{
		MultiGetUsersByNamesRequest requestData = new MultiGetUsersByNamesRequest
		{
			Names = names,
			IncludeUsernameHistory = includeUsernameHistory
		};
		return _ServiceRequestSender.SendPostRequestAsync<MultiGetUsersByNamesRequest, IDictionary<string, UserData>>("/v1/MultiGetUsersByNames", requestData, cancellationToken);
	}

	public UserData GetUserById(long userId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = userId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, UserData>("/v1/GetUserById", requestData);
	}

	public Task<UserData> GetUserByIdAsync(long userId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = userId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, UserData>("/v1/GetUserById", requestData, cancellationToken);
	}

	public IDictionary<long, UserData> MultiGetUsersByIds(ISet<long> userIds)
	{
		Payload<ISet<long>> requestData = new Payload<ISet<long>>
		{
			Data = userIds
		};
		return _ServiceRequestSender.SendPostRequest<Payload<ISet<long>>, IDictionary<long, UserData>>("/v1/MultiGetUsersByIds", requestData);
	}

	public Task<IDictionary<long, UserData>> MultiGetUsersByIdsAsync(ISet<long> userIds, CancellationToken cancellationToken)
	{
		Payload<ISet<long>> requestData = new Payload<ISet<long>>
		{
			Data = userIds
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<ISet<long>>, IDictionary<long, UserData>>("/v1/MultiGetUsersByIds", requestData, cancellationToken);
	}

	public UserData GetUserByAccountId(long accountId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = accountId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, UserData>("/v1/GetUserByAccountId", requestData);
	}

	public Task<UserData> GetUserByAccountIdAsync(long accountId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = accountId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, UserData>("/v1/GetUserByAccountId", requestData, cancellationToken);
	}

	public IDictionary<long, UserData> MultiGetUsersByAccountIds(ISet<long> accountIds)
	{
		Payload<ISet<long>> requestData = new Payload<ISet<long>>
		{
			Data = accountIds
		};
		return _ServiceRequestSender.SendPostRequest<Payload<ISet<long>>, IDictionary<long, UserData>>("/v1/MultiGetUsersByAccountIds", requestData);
	}

	public Task<IDictionary<long, UserData>> MultiGetUsersByAccountIdsAsync(ISet<long> accountIds, CancellationToken cancellationToken)
	{
		Payload<ISet<long>> requestData = new Payload<ISet<long>>
		{
			Data = accountIds
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<ISet<long>>, IDictionary<long, UserData>>("/v1/MultiGetUsersByAccountIds", requestData, cancellationToken);
	}

	public SetUserModerationStatusResult SetUserModerationStatus(long userId, UserModerationStatus moderationStatus)
	{
		SetUserModerationStatusRequest requestData = new SetUserModerationStatusRequest
		{
			UserId = userId,
			ModerationStatus = moderationStatus
		};
		return _ServiceRequestSender.SendPostRequest<SetUserModerationStatusRequest, SetUserModerationStatusResult>("/v1/SetUserModerationStatus", requestData);
	}

	public Task<SetUserModerationStatusResult> SetUserModerationStatusAsync(long userId, UserModerationStatus moderationStatus, CancellationToken cancellationToken)
	{
		SetUserModerationStatusRequest requestData = new SetUserModerationStatusRequest
		{
			UserId = userId,
			ModerationStatus = moderationStatus
		};
		return _ServiceRequestSender.SendPostRequestAsync<SetUserModerationStatusRequest, SetUserModerationStatusResult>("/v1/SetUserModerationStatus", requestData, cancellationToken);
	}

	public SetUserDescriptionResult SetUserDescription(long userId, string description)
	{
		SetUserDescriptionRequest requestData = new SetUserDescriptionRequest
		{
			UserId = userId,
			Description = description
		};
		return _ServiceRequestSender.SendPostRequest<SetUserDescriptionRequest, SetUserDescriptionResult>("/v1/SetUserDescription", requestData);
	}

	public Task<SetUserDescriptionResult> SetUserDescriptionAsync(long userId, string description, CancellationToken cancellationToken)
	{
		SetUserDescriptionRequest requestData = new SetUserDescriptionRequest
		{
			UserId = userId,
			Description = description
		};
		return _ServiceRequestSender.SendPostRequestAsync<SetUserDescriptionRequest, SetUserDescriptionResult>("/v1/SetUserDescription", requestData, cancellationToken);
	}

	public SetUserBirthdateResult SetUserBirthdate(long userId, DateTime? birthdate)
	{
		SetUserBirthdateRequest requestData = new SetUserBirthdateRequest
		{
			UserId = userId,
			Birthdate = birthdate
		};
		return _ServiceRequestSender.SendPostRequest<SetUserBirthdateRequest, SetUserBirthdateResult>("/v1/SetUserBirthdate", requestData);
	}

	public Task<SetUserBirthdateResult> SetUserBirthdateAsync(long userId, DateTime? birthdate, CancellationToken cancellationToken)
	{
		SetUserBirthdateRequest requestData = new SetUserBirthdateRequest
		{
			UserId = userId,
			Birthdate = birthdate
		};
		return _ServiceRequestSender.SendPostRequestAsync<SetUserBirthdateRequest, SetUserBirthdateResult>("/v1/SetUserBirthdate", requestData, cancellationToken);
	}

	public SetUserGenderResult SetUserGender(long userId, UserGender gender)
	{
		SetUserGenderRequest requestData = new SetUserGenderRequest
		{
			UserId = userId,
			Gender = gender
		};
		return _ServiceRequestSender.SendPostRequest<SetUserGenderRequest, SetUserGenderResult>("/v1/SetUserGender", requestData);
	}

	public Task<SetUserGenderResult> SetUserGenderAsync(long userId, UserGender gender, CancellationToken cancellationToken)
	{
		SetUserGenderRequest requestData = new SetUserGenderRequest
		{
			UserId = userId,
			Gender = gender
		};
		return _ServiceRequestSender.SendPostRequestAsync<SetUserGenderRequest, SetUserGenderResult>("/v1/SetUserGender", requestData, cancellationToken);
	}

	public SetUserAgeBracketResult SetUserAgeBracket(long userId, UserAgeBracket ageBracket)
	{
		SetUserAgeBracketRequest requestData = new SetUserAgeBracketRequest
		{
			UserId = userId,
			AgeBracket = ageBracket
		};
		return _ServiceRequestSender.SendPostRequest<SetUserAgeBracketRequest, SetUserAgeBracketResult>("/v1/SetUserAgeBracket", requestData);
	}

	public Task<SetUserAgeBracketResult> SetUserAgeBracketAsync(long userId, UserAgeBracket ageBracket, CancellationToken cancellationToken)
	{
		SetUserAgeBracketRequest requestData = new SetUserAgeBracketRequest
		{
			UserId = userId,
			AgeBracket = ageBracket
		};
		return _ServiceRequestSender.SendPostRequestAsync<SetUserAgeBracketRequest, SetUserAgeBracketResult>("/v1/SetUserAgeBracket", requestData, cancellationToken);
	}

	public ICollection<long> GetRecentlyUpdatedUsers(DateTime? updatedAfterDate)
	{
		Payload<DateTime?> requestData = new Payload<DateTime?>
		{
			Data = updatedAfterDate
		};
		return _ServiceRequestSender.SendPostRequest<Payload<DateTime?>, ICollection<long>>("/v1/GetRecentlyUpdatedUsers", requestData);
	}

	public Task<ICollection<long>> GetRecentlyUpdatedUsersAsync(DateTime? updatedAfterDate, CancellationToken cancellationToken)
	{
		Payload<DateTime?> requestData = new Payload<DateTime?>
		{
			Data = updatedAfterDate
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<DateTime?>, ICollection<long>>("/v1/GetRecentlyUpdatedUsers", requestData, cancellationToken);
	}

	public ReindexUserResult ReindexUser(long userId, bool flushCache)
	{
		ReindexUserRequest requestData = new ReindexUserRequest
		{
			UserId = userId,
			FlushCache = flushCache
		};
		return _ServiceRequestSender.SendPostRequest<ReindexUserRequest, ReindexUserResult>("/v1/ReindexUser", requestData);
	}

	public Task<ReindexUserResult> ReindexUserAsync(long userId, bool flushCache, CancellationToken cancellationToken)
	{
		ReindexUserRequest requestData = new ReindexUserRequest
		{
			UserId = userId,
			FlushCache = flushCache
		};
		return _ServiceRequestSender.SendPostRequestAsync<ReindexUserRequest, ReindexUserResult>("/v1/ReindexUser", requestData, cancellationToken);
	}

	public long GetOrCreateGroupAgentId(long groupId)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = groupId
		};
		return _ServiceRequestSender.SendPostRequest<Payload<long>, long>("/v1/GetOrCreateGroupAgentId", requestData);
	}

	public Task<long> GetOrCreateGroupAgentIdAsync(long groupId, CancellationToken cancellationToken)
	{
		Payload<long> requestData = new Payload<long>
		{
			Data = groupId
		};
		return _ServiceRequestSender.SendPostRequestAsync<Payload<long>, long>("/v1/GetOrCreateGroupAgentId", requestData, cancellationToken);
	}

	public UserData CreateUser(string name, UserGender? gender, DateTime? birthdate, UserAgeBracket? ageBracket)
	{
		CreateUserRequest requestData = new CreateUserRequest
		{
			Name = name,
			Gender = gender,
			Birthdate = birthdate,
			AgeBracket = ageBracket
		};
		return _ServiceRequestSender.SendPostRequest<CreateUserRequest, UserData>("/v1/CreateUser", requestData);
	}

	public Task<UserData> CreateUserAsync(string name, UserGender? gender, DateTime? birthdate, UserAgeBracket? ageBracket, CancellationToken cancellationToken)
	{
		CreateUserRequest requestData = new CreateUserRequest
		{
			Name = name,
			Gender = gender,
			Birthdate = birthdate,
			AgeBracket = ageBracket
		};
		return _ServiceRequestSender.SendPostRequestAsync<CreateUserRequest, UserData>("/v1/CreateUser", requestData, cancellationToken);
	}

	public ChangeDisplayNameResult ChangeDisplayName(long userId, string currentDisplayName, string newDisplayName, bool recordHistory)
	{
		ChangeDisplayNameRequest requestData = new ChangeDisplayNameRequest
		{
			UserId = userId,
			CurrentDisplayName = currentDisplayName,
			NewDisplayName = newDisplayName,
			RecordHistory = recordHistory
		};
		return _ServiceRequestSender.SendPostRequest<ChangeDisplayNameRequest, ChangeDisplayNameResult>("/v1/ChangeDisplayName", requestData);
	}

	public Task<ChangeDisplayNameResult> ChangeDisplayNameAsync(long userId, string currentDisplayName, string newDisplayName, bool recordHistory, CancellationToken cancellationToken)
	{
		ChangeDisplayNameRequest requestData = new ChangeDisplayNameRequest
		{
			UserId = userId,
			CurrentDisplayName = currentDisplayName,
			NewDisplayName = newDisplayName,
			RecordHistory = recordHistory
		};
		return _ServiceRequestSender.SendPostRequestAsync<ChangeDisplayNameRequest, ChangeDisplayNameResult>("/v1/ChangeDisplayName", requestData, cancellationToken);
	}

	public HistoricalDisplayName[] GetDisplayNameHistoryByUserId(long userId, int count, SortOrder sortOrder, long? exclusiveStartId)
	{
		GetDisplayNameHistoryByUserIdRequest requestData = new GetDisplayNameHistoryByUserIdRequest
		{
			UserId = userId,
			Count = count,
			SortOrder = sortOrder,
			ExclusiveStartId = exclusiveStartId
		};
		return _ServiceRequestSender.SendPostRequest<GetDisplayNameHistoryByUserIdRequest, HistoricalDisplayName[]>("/v1/GetDisplayNameHistoryByUserId", requestData);
	}

	public Task<HistoricalDisplayName[]> GetDisplayNameHistoryByUserIdAsync(long userId, int count, SortOrder sortOrder, long? exclusiveStartId, CancellationToken cancellationToken)
	{
		GetDisplayNameHistoryByUserIdRequest requestData = new GetDisplayNameHistoryByUserIdRequest
		{
			UserId = userId,
			Count = count,
			SortOrder = sortOrder,
			ExclusiveStartId = exclusiveStartId
		};
		return _ServiceRequestSender.SendPostRequestAsync<GetDisplayNameHistoryByUserIdRequest, HistoricalDisplayName[]>("/v1/GetDisplayNameHistoryByUserId", requestData, cancellationToken);
	}

	private static ClientCircuitBreakerType GetClientCircuitBreakerType()
	{
		if (!Settings.Default.PerEndpointCircuitBreakerEnabled)
		{
			return (ClientCircuitBreakerType)1;
		}
		return (ClientCircuitBreakerType)2;
	}

	private static bool ApiKeyViaHeaderEnabled()
	{
		return Settings.Default.ApiKeyViaHeaderEnabled;
	}

	private static IHttpClientBuilder CreateHttpClientBuilder(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader)
	{
		var builder = new Roblox.Http.ServiceClient.HttpClientBuilder((IServiceClientSettings)Settings.Default, counterRegistry, apiKeyGetter, (CookieContainer)null, requestContextLoader);
		builder.ApiKeyViaHeaderEnabled = ApiKeyViaHeaderEnabled;
		// GetClientCircuitBreakerType is not a property of HttpClientBuilder, so we can't set it directly
		return builder;
	}
}
