using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.CommunitySift.Properties;
using Roblox.RestClientBase;

namespace Roblox.CommunitySift;

/// <summary>
/// CommunitySift Client
/// </summary>
public class CommunitySiftClient : ICommunitySiftClient
{
	private readonly ICommunitySiftRestClient _RestClient;

	private readonly ICommunitySiftPerformanceMonitor _PerformanceMonitor;

	private readonly ICommunitySiftTopicTranslator _TopicTranslator;

	private readonly ICommunitySiftSettings _Settings;

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="restClient">The <see cref="T:Roblox.CommunitySift.ICommunitySiftRestClient" /> responsible for making the actual Http calls.</param>
	/// <param name="apiName">Name of the parent service making these called. Used for logging.</param>
	/// <exception cref="T:System.ArgumentNullException"></exception>
	public CommunitySiftClient(ICommunitySiftRestClient restClient, string apiName = "Unknown")
		: this(restClient, new CommunitySiftPerformanceMonitor(apiName, Settings.Default), new CommunitySiftTopicTranslator(Settings.Default), Settings.Default)
	{
	}

	/// <summary>
	/// Internal constructor allows us access to the performanceMonitor.
	/// </summary>
	/// <param name="restClient"></param>
	/// <param name="performanceMonitor"></param>
	/// <param name="topicTranslator"></param>
	/// <param name="settings">Settings for the Client</param>
	internal CommunitySiftClient(ICommunitySiftRestClient restClient, ICommunitySiftPerformanceMonitor performanceMonitor, ICommunitySiftTopicTranslator topicTranslator, ICommunitySiftSettings settings)
	{
		_RestClient = restClient ?? throw new ArgumentNullException("restClient");
		_PerformanceMonitor = performanceMonitor ?? throw new ArgumentNullException("performanceMonitor");
		_TopicTranslator = topicTranslator ?? throw new ArgumentNullException("topicTranslator");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <summary>
	/// Post a short piece of text to CommunitySift.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftChatRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftChatFilterResult" /> containing the filter result.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	public ICommunitySiftChatFilterResult PostChat(ICommunitySiftChatRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return new CommunitySiftChatFilterResult
			{
				TextWasFiltered = true,
				FilteredText = ""
			};
		}
		int ruleSet = (request.IsUnder13 ? _Settings.CommunitySiftTextFilteringUnder13Rule : _Settings.CommunitySiftTextFiltering13AndOverRule);
		Tuple<string, string> roomAndServer = RoomAndServerRandomizer(request.Room, request.Server);
		CommunitySiftChatRequestBody chatRequestBody = new CommunitySiftChatRequestBody
		{
			UserId = request.UserId,
			Username = request.UserName,
			Text = request.Text,
			Language = "*",
			Room = roomAndServer.Item1,
			Server = roomAndServer.Item2,
			RuleSet = ruleSet
		};
		Stopwatch watch = new Stopwatch();
		CommunitySiftChatResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<CommunitySiftChatResponseData>(_Settings.CommunitySiftChatEndpoint, Roblox.RestClientBase.RestClientBase.HttpMethod.Post, null, chatRequestBody);
			watch.Stop();
		}
		catch (Exception ex)
		{
			watch.Stop();
			_PerformanceMonitor.IncrementException(chatRequestBody, watch.Elapsed, PerformanceCounterRequestType.Chat, ex);
			throw new CommunitySiftException("CommunitySift is unavailable", ex);
		}
		_PerformanceMonitor.Increment(watch.Elapsed, PerformanceCounterRequestType.Chat);
		ValidateChatResponseConsistency(chatRequestBody, responseData);
		return new CommunitySiftChatFilterResult
		{
			TextWasFiltered = !responseData.Response,
			FilteredText = responseData.Hashed,
			FilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics ?? new Dictionary<int, int>(), request.IsUnder13)
		};
	}

	private void ValidateChatResponseConsistency(CommunitySiftChatRequestBody chatRequestBody, CommunitySiftChatResponseData responseData)
	{
		if (!responseData.Response && string.IsNullOrWhiteSpace(responseData.Hashed))
		{
			_PerformanceMonitor.IncrementResponseIsFalseHashIsWrong();
		}
		if (responseData.Response && !string.IsNullOrWhiteSpace(responseData.Hashed))
		{
			_PerformanceMonitor.IncrementResponseIsTrueHashIsSet();
			int octothorpesInHashed = responseData.Hashed.Count((char x) => x.Equals('#'));
			if (chatRequestBody.Text.Count((char x) => x.Equals('#')) != octothorpesInHashed)
			{
				_PerformanceMonitor.IncrementResponseIsTrueHashesCountDiffers();
			}
		}
	}

	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftClient" />
	public ICommunitySiftChatFilterNoContextResult PostChatNoContext(ICommunitySiftChatNoContextRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return new CommunitySiftChatFilterNoContextResult
			{
				TextWasFiltered = true,
				FilteredText = ""
			};
		}
		int ruleSet = (request.IsUnder13 ? _Settings.CommunitySiftTextFilteringUnder13Rule : _Settings.CommunitySiftTextFiltering13AndOverRule);
		Tuple<string, string> roomAndServer = RoomAndServerRandomizer(request.Room, request.Server);
		CommunitySiftChatNoContextRequestBody chatRequestBody = new CommunitySiftChatNoContextRequestBody
		{
			UserId = request.UserId.ToString(),
			Username = request.UserName,
			Text = request.Text,
			Language = "*",
			Room = roomAndServer.Item1,
			Server = roomAndServer.Item2,
			RuleSet = ruleSet.ToString()
		};
		Stopwatch watch = new Stopwatch();
		CommunitySiftChatNoContextResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<CommunitySiftChatNoContextResponseData>(_Settings.CommunitySiftChatNoContextEndpoint, Roblox.RestClientBase.RestClientBase.HttpMethod.Post, null, chatRequestBody);
			watch.Stop();
		}
		catch (Exception ex)
		{
			watch.Stop();
			_PerformanceMonitor.IncrementException(chatRequestBody, watch.Elapsed, PerformanceCounterRequestType.ChatNoContext, ex);
			throw new CommunitySiftException("CommunitySift is unavailable", ex);
		}
		_PerformanceMonitor.Increment(watch.Elapsed, PerformanceCounterRequestType.ChatNoContext);
		return new CommunitySiftChatFilterNoContextResult
		{
			TextWasFiltered = !responseData.Response,
			FilteredText = responseData.RedactedText,
			FilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics ?? new Dictionary<int, int>(), request.IsUnder13)
		};
	}

	/// <summary>
	/// Post a long piece of text to CommunitySift.
	/// Generally 1000+ characters.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftLongTextRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftChatFilterResult" /> containing the filter result.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	public ICommunitySiftLongTextFilterResult PostLongText(ICommunitySiftLongTextRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return new CommunitySiftLongTextFilterResult
			{
				TextWasFiltered = true,
				FilteredText = ""
			};
		}
		int ruleSet = (request.IsUnder13 ? _Settings.CommunitySiftTextFilteringUnder13Rule : _Settings.CommunitySiftTextFiltering13AndOverRule);
		Tuple<string, string> roomAndServer = RoomAndServerRandomizer(request.Room, request.Server);
		CommunitySiftLongTextRequestBody longTextRequestBody = new CommunitySiftLongTextRequestBody
		{
			UserId = request.UserId.ToString(),
			Username = request.UserName,
			Text = request.Text,
			Language = "*",
			Room = roomAndServer.Item1,
			Server = roomAndServer.Item2,
			RuleSet = ruleSet.ToString()
		};
		Stopwatch watch = new Stopwatch();
		CommunitySiftLongTextResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<CommunitySiftLongTextResponseData>(_Settings.CommunitySiftLongTextEndpoint, Roblox.RestClientBase.RestClientBase.HttpMethod.Post, null, longTextRequestBody);
			watch.Stop();
		}
		catch (Exception ex)
		{
			watch.Stop();
			_PerformanceMonitor.IncrementException(longTextRequestBody, watch.Elapsed, PerformanceCounterRequestType.LongText, ex);
			throw new CommunitySiftException("CommunitySift is unavailable", ex);
		}
		_PerformanceMonitor.Increment(watch.Elapsed, PerformanceCounterRequestType.LongText);
		if (responseData.Response)
		{
			return new CommunitySiftLongTextFilterResult
			{
				TextWasFiltered = !responseData.Response,
				FilteredText = "",
				FilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics ?? new Dictionary<int, int>(), request.IsUnder13)
			};
		}
		string responseText = "[REDACTED]";
		return ComposeLongTextResultFromFragments(request, responseData, ref responseText);
	}

	private ICommunitySiftLongTextFilterResult ComposeLongTextResultFromFragments(ICommunitySiftLongTextRequest request, CommunitySiftLongTextResponseData responseData, ref string responseText)
	{
		CommunitySiftLongTextFragment[] failingFragments = responseData.FailingFragments;
		if (failingFragments == null || !failingFragments.ToList().Aggregate(seed: false, (bool timeout, CommunitySiftLongTextFragment fragment) => timeout || fragment.Timeout))
		{
			responseText = responseData.FailingFragments?.ToList().Aggregate(request.Text, ProcessFragment) ?? "";
		}
		return new CommunitySiftLongTextFilterResult
		{
			TextWasFiltered = !responseData.Response,
			FilteredText = responseText,
			FilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics ?? new Dictionary<int, int>(), request.IsUnder13)
		};
	}

	private static string ProcessFragment(string original, CommunitySiftLongTextFragment fragment)
	{
		if (fragment.Hashed != null)
		{
			return original.Remove(fragment.FragmentStart, fragment.FragmentLength).Insert(fragment.FragmentStart, fragment.Hashed) + " ";
		}
		return original;
	}

	/// <summary>
	/// Post a piece of chat as both under and over 13 in a single call.
	/// Note that the chat will be truncated to 1000 characters. For longer text use PostLongText().
	/// </summary>
	/// <param name="request">An <see cref="T:Roblox.CommunitySift.ICommunitySiftDoubleChatRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftDoubleChatFilterResult" /> containing the results for both age categories.</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	public ICommunitySiftDoubleChatFilterResult PostDoubleChat(ICommunitySiftDoubleChatRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return new CommunitySiftDoubleChatFilterResult
			{
				PrimaryTextWasFiltered = true,
				PrimaryFilteredText = "",
				PrimaryFilteredCategories = new HashSet<CommunitySiftModerationTopic>(),
				SecondaryTextWasFiltered = true,
				SecondaryFilteredText = "",
				SecondaryFilteredCategories = new HashSet<CommunitySiftModerationTopic>()
			};
		}
		Tuple<string, string> roomAndServer = RoomAndServerRandomizer(request.Room, request.Server);
		CommunitySiftDoubleChatRequestBody doubleChatRequestBody = new CommunitySiftDoubleChatRequestBody
		{
			UserId = request.UserId.ToString(),
			UserName = request.UserName,
			Text = ((request.Text.Length <= 1000) ? request.Text : request.Text.Substring(0, 1000)),
			Room = roomAndServer.Item1,
			Server = roomAndServer.Item2,
			PrimaryRuleId = _Settings.CommunitySiftTextFiltering13AndOverRule.ToString(),
			SecondaryRuleId = _Settings.CommunitySiftTextFilteringUnder13Rule.ToString()
		};
		Stopwatch watch = new Stopwatch();
		CommunitySiftDoubleChatResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<CommunitySiftDoubleChatResponseData>(_Settings.CommunitySiftDoubleChatEndpoint, Roblox.RestClientBase.RestClientBase.HttpMethod.Post, null, doubleChatRequestBody);
			watch.Stop();
		}
		catch (Exception ex)
		{
			watch.Stop();
			_PerformanceMonitor.IncrementException(doubleChatRequestBody, watch.Elapsed, PerformanceCounterRequestType.DoubleChat, ex);
			throw new CommunitySiftException("CommunitySift is unavailable", ex);
		}
		_PerformanceMonitor.Increment(watch.Elapsed, PerformanceCounterRequestType.DoubleChat);
		ValidateDoubleChatResponseConsistency(request, responseData);
		return new CommunitySiftDoubleChatFilterResult
		{
			PrimaryTextWasFiltered = !responseData.PrimaryResponse,
			PrimaryFilteredText = (responseData.PrimaryResponse ? null : responseData.Hashed),
			PrimaryFilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics, isUnder13: false),
			SecondaryTextWasFiltered = !responseData.SecondaryResponse,
			SecondaryFilteredText = (responseData.SecondaryResponse ? null : responseData.SecondaryHashed),
			SecondaryFilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics, isUnder13: true),
			Trust = responseData.Trust
		};
	}

	private void ValidateDoubleChatResponseConsistency(ICommunitySiftDoubleChatRequest request, CommunitySiftDoubleChatResponseData responseData)
	{
		if (!responseData.PrimaryResponse && responseData.Hashed != null && responseData.Hashed.Equals(request.Text))
		{
			_PerformanceMonitor.IncrementResponseIsFalseHashIsWrong();
		}
		if (responseData.PrimaryResponse && responseData.Hashed != null && !responseData.Hashed.Equals(request.Text))
		{
			_PerformanceMonitor.IncrementResponseIsTrueHashIsSet();
			int octothorpesInHashed2 = responseData.Hashed.Count((char x) => x.Equals('#'));
			if (request.Text.Count((char x) => x.Equals('#')) != octothorpesInHashed2)
			{
				_PerformanceMonitor.IncrementResponseIsTrueHashesCountDiffers();
			}
		}
		if (!responseData.SecondaryResponse && responseData.SecondaryHashed != null && responseData.SecondaryHashed.Equals(request.Text))
		{
			_PerformanceMonitor.IncrementResponseIsFalseHashIsWrong();
		}
		if (responseData.SecondaryResponse && responseData.SecondaryHashed != null && !responseData.SecondaryHashed.Equals(request.Text))
		{
			_PerformanceMonitor.IncrementResponseIsTrueHashIsSet();
			int octothorpesInHashed = responseData.SecondaryHashed.Count((char x) => x.Equals('#'));
			if (request.Text.Count((char x) => x.Equals('#')) != octothorpesInHashed)
			{
				_PerformanceMonitor.IncrementResponseIsTrueHashesCountDiffers();
			}
		}
	}

	/// <summary>
	/// Post a the given UserName and check its validatity for both over and under 13.
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.CommunitySift.ICommunitySiftUserNameRequest" /> containing the required parameters for CommunitySift</param>
	/// <returns>An <see cref="T:Roblox.CommunitySift.ICommunitySiftUserNameRequest" /> containing the results for both age categories</returns>
	/// <exception cref="T:Roblox.CommunitySift.CommunitySiftException"></exception>
	public ICommunitySiftUserNameFilterResult PostUserName(ICommunitySiftUserNameRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (string.IsNullOrWhiteSpace(request.Text))
		{
			return new CommunitySiftUserNameFilterResult
			{
				IsPrimaryTextFiltered = true,
				PrimaryFilteredText = "",
				IsSecondaryTextFiltered = true,
				SecondaryFilteredText = ""
			};
		}
		CommunitySiftUserNameRequestBody userNameRequestBody = new CommunitySiftUserNameRequestBody
		{
			UserId = request.UserId,
			UserName = request.Text,
			Language = "*",
			PrimaryRuleId = _Settings.CommunitySiftUserNameFiltering13AndOverRule.ToString(),
			SecondaryRuleId = _Settings.CommunitySiftUserNameFilteringUnder13Rule.ToString()
		};
		Stopwatch watch = new Stopwatch();
		CommunitySiftUserNameResponseData responseData;
		try
		{
			watch.Start();
			responseData = _RestClient.ExecuteHttpRequest<CommunitySiftUserNameResponseData>(_Settings.CommunitySiftUserNameEndpoint, Roblox.RestClientBase.RestClientBase.HttpMethod.Post, null, userNameRequestBody);
			watch.Stop();
		}
		catch (Exception ex)
		{
			watch.Stop();
			_PerformanceMonitor.IncrementException(userNameRequestBody, watch.Elapsed, PerformanceCounterRequestType.UserName, ex);
			throw new CommunitySiftException("CommunitySift is unavailable", ex);
		}
		_PerformanceMonitor.Increment(watch.Elapsed, PerformanceCounterRequestType.UserName);
		return new CommunitySiftUserNameFilterResult
		{
			IsPrimaryTextFiltered = !responseData.PrimaryRuleResponse,
			PrimaryFilteredText = responseData.PrimaryHashed,
			IsSecondaryTextFiltered = !responseData.SecondaryRuleResponse,
			SecondaryFilteredText = responseData.SecondaryHashed,
			FilteredCategories = _TopicTranslator.ExtractFilteredTopics(responseData.Topics ?? new Dictionary<int, int>(), request.IsUnder13)
		};
	}

	private Tuple<string, string> RoomAndServerRandomizer(string room, string server)
	{
		if (!string.IsNullOrWhiteSpace(server) && string.IsNullOrWhiteSpace(room))
		{
			room = Guid.NewGuid().ToString();
		}
		else if (string.IsNullOrWhiteSpace(server) && !string.IsNullOrWhiteSpace(room))
		{
			server = Guid.NewGuid().ToString();
		}
		return new Tuple<string, string>(room, server);
	}
}
