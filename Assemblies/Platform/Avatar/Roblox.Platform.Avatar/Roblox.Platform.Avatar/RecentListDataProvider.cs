using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Avatar;

internal class RecentListDataProvider
{
	private const int _StartingRevision = 1;

	public static Func<int> MaxRecentItems = () => Math.Max(0, Math.Min(Settings.Default.RecentAvatarItemsMaxItemsPerList, 50));

	public static Func<int> MaxRetriesToUpdateRecentItemsList = () => Settings.Default.RecentAvatarItemsMaxUpdateRetries;

	private readonly BlockingCollection<RecentItem> _AddBuffer = new BlockingCollection<RecentItem>();

	private readonly BlockingCollection<RecentItem> _RemoveBuffer = new BlockingCollection<RecentItem>();

	public readonly IRecentItemListTypeEntity ItemListType;

	private List<RecentItem> _Items = new List<RecentItem>();

	private IRecentItemListEntity _RecentItemList;

	private readonly AvatarDomainFactories _AvatarDomainFactory;

	public static event EventHandler MaxRetriesReached;

	public RecentListDataProvider(IUserIdentifier user, IRecentItemListTypeEntity itemListType, AvatarDomainFactories avatarDomainFactories)
	{
		ItemListType = itemListType;
		_AvatarDomainFactory = avatarDomainFactories;
		_RecentItemList = _AvatarDomainFactory.RecentItemListEntityFactory.GetOrCreate(user.Id, ItemListType.Id);
		LoadFromColumns();
	}

	public bool IsPopulated()
	{
		return _RecentItemList.Revision > 1;
	}

	public ICollection<RecentItem> GetItems()
	{
		return _Items;
	}

	public void Add(RecentItem recentItem)
	{
		_AddBuffer.Add(recentItem);
		_Items.Add(recentItem);
		SortByDateRemoveDuplicatesAndTruncate();
	}

	public void Remove(RecentItem recentItem)
	{
		if (_Items.Contains(recentItem))
		{
			_RemoveBuffer.Add(recentItem);
			_Items.Remove(recentItem);
		}
	}

	private void LoadFromColumns()
	{
		List<RecentItem> items = new List<RecentItem>(MaxRecentItems());
		using (IEnumerator<byte> typeIter = _RecentItemList.RecentItemTypeIds.AsEnumerable().GetEnumerator())
		{
			using IEnumerator<long> targetIter = _RecentItemList.TargetIds.AsEnumerable().GetEnumerator();
			using IEnumerator<DateTime> dateIter = _RecentItemList.Dates.AsEnumerable().GetEnumerator();
			while (typeIter.MoveNext() && items.Count < MaxRecentItems())
			{
				if (!targetIter.MoveNext() || !dateIter.MoveNext())
				{
					ExceptionHandler.LogException($"Iterators for Type/Target/Date do not have same length in RecentAvatarItemList for UserId {_RecentItemList.UserId} RecentItemListId {_RecentItemList.Id}");
					break;
				}
				long current = targetIter.Current;
				byte typeId = typeIter.Current;
				DateTime date = dateIter.Current;
				IRecentItemTypeEntity type = _AvatarDomainFactory.RecentItemTypeEntityFactory.Get(typeId);
				RecentItem recentItem = new RecentItem(current, type, date);
				items.Add(recentItem);
			}
		}
		_Items = items;
	}

	private void WriteToRecentItemList(IRecentItemListEntity itemList)
	{
		_Items = _Items.Take(MaxRecentItems()).ToList();
		itemList.RecentItemTypeIds = _Items.Select((RecentItem r) => r.TypeId).ToArray();
		itemList.TargetIds = _Items.Select((RecentItem r) => r.TargetId).ToArray();
		itemList.Dates = _Items.Select((RecentItem r) => r.Date).ToArray();
	}

	private void SortByDateRemoveDuplicatesAndTruncate()
	{
		List<RecentItem> newList = _Items.OrderByDescending((RecentItem r) => r.Date).DistinctBy((RecentItem r) => r.GetUniqueCode()).Take(MaxRecentItems())
			.ToList();
		_Items = newList;
	}

	private bool HasPendingChanges()
	{
		if (!_AddBuffer.Any())
		{
			return _RemoveBuffer.Any();
		}
		return true;
	}

	private void ClearPendingChanges()
	{
		while (_RemoveBuffer.Count > 0)
		{
			_RemoveBuffer.TryTake(out var _);
		}
		while (_AddBuffer.Count > 0)
		{
			_AddBuffer.TryTake(out var _);
		}
	}

	private void ApplyPendingChanges()
	{
		foreach (RecentItem recentItem2 in (IEnumerable<RecentItem>)_RemoveBuffer)
		{
			_Items.Remove(recentItem2);
		}
		foreach (RecentItem recentItem in (IEnumerable<RecentItem>)_AddBuffer)
		{
			_Items.Add(recentItem);
		}
	}

	public void Save()
	{
		if (!HasPendingChanges())
		{
			return;
		}
		int attempts = 0;
		while (attempts == 0 || attempts <= MaxRetriesToUpdateRecentItemsList())
		{
			attempts++;
			WriteToRecentItemList(_RecentItemList);
			if (_RecentItemList.Save())
			{
				ClearPendingChanges();
				return;
			}
			IRecentItemListEntity latest = _AvatarDomainFactory.RecentItemListEntityFactory.Get(_RecentItemList.Id);
			if (latest.Revision == _RecentItemList.Revision)
			{
				throw new PlatformException("Update failed but after fetching latest revision from BLL, got the same itemList back");
			}
			if (latest.Revision > _RecentItemList.Revision)
			{
				_RecentItemList = latest;
				LoadFromColumns();
				ApplyPendingChanges();
				SortByDateRemoveDuplicatesAndTruncate();
			}
		}
		RecentListDataProvider.MaxRetriesReached?.Invoke(this, null);
	}
}
