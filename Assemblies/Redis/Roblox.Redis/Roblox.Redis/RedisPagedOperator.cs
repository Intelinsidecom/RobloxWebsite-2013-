using System;
using System.Collections.Generic;
using StackExchange.Redis;

namespace Roblox.Redis;

public static class RedisPagedOperator
{
	public static void DeleteSortedSetEntriesPaged(this IRedisClient redisClient, string key, double inclusiveMinScore, double inclusiveMaxScore, int pageSize, CommandFlags deletionCommandFlags)
	{
		foreach (Tuple<double, double> range in redisClient.GetSortedSetRanges(key, inclusiveMinScore, inclusiveMaxScore, pageSize))
		{
			redisClient.Execute(key, (IDatabase db) => db.SortedSetRemoveRangeByScore(key, range.Item1, range.Item2, Exclude.None, deletionCommandFlags));
		}
	}

	private static IReadOnlyCollection<Tuple<double, double>> GetSortedSetRanges(this IRedisClient redisClient, string key, double inclusiveMinScore, double inclusiveMaxScore, int pageSize)
	{
		long num = 0L;
		SortedSetEntry[] array = null;
		double stopScoreToFetchUpto = inclusiveMaxScore;
		double? num2 = null;
		List<Tuple<double, double>> list = new List<Tuple<double, double>>();
		do
		{
			long startIndex = num;
			if (!num2.HasValue)
			{
				array = redisClient.Execute(key, (IDatabase db) => db.SortedSetRangeByScoreWithScores(key, inclusiveMinScore, stopScoreToFetchUpto, Exclude.None, Order.Ascending, startIndex, 1L));
				if (array == null || array.Length == 0)
				{
					break;
				}
				num2 = array[0].Score;
			}
			array = redisClient.Execute(key, (IDatabase db) => db.SortedSetRangeByScoreWithScores(key, inclusiveMinScore, stopScoreToFetchUpto, Exclude.None, Order.Ascending, startIndex + pageSize, 1L));
			double num3 = inclusiveMaxScore;
			if (array != null && array.Length != 0)
			{
				num3 = array[0].Score;
			}
			list.Add(new Tuple<double, double>(num2.Value, num3));
			num += pageSize;
			num2 = num3;
		}
		while (array != null && array.Length != 0);
		return list;
	}
}
