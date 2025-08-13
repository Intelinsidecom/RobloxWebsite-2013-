using System;
using System.Collections.Generic;

namespace Roblox.Common.NetStandard;

public static class CollectionsHelper
{
	public delegate ICollection<T> PageGetterLong<T>(long startRowIndex, long maxRows);

	public delegate ICollection<T> PageGetterInt<T>(int startRowIndex, int maxRows);

	public static T GetRandomElement<T>(this IList<T> self)
	{
		if (self.Count == 0)
		{
			return default(T);
		}
		Random random = new Random();
		return self[random.Next(self.Count)];
	}

	public static void Swap<T>(T[] array, int i, int j)
	{
		T val = array[i];
		array[i] = array[j];
		array[j] = val;
	}

	public static IEnumerable<T> RandomizeCollection<T>(this ICollection<T> collection, int numberofItemsToReturn)
	{
		return collection.SampleRandomElements(numberofItemsToReturn, (T t) => true);
	}

	public static IEnumerable<T> SampleRandomElements<T>(this ICollection<T> collection, int numberofItemsToReturn, Func<T, bool> predicate)
	{
		int num = collection.Count;
		T[] array = new T[num];
		collection.CopyTo(array, 0);
		if (numberofItemsToReturn > num)
		{
			numberofItemsToReturn = num;
		}
		Random random = new Random();
		for (int j = 0; j < numberofItemsToReturn && j < num; j++)
		{
			int num2 = random.Next(j, num);
			if (!predicate(array[num2]))
			{
				num--;
				Swap(array, num2, num);
				j--;
			}
			else
			{
				Swap(array, j, num2);
			}
		}
		if (numberofItemsToReturn > num)
		{
			numberofItemsToReturn = num;
		}
		for (int i = 0; i < numberofItemsToReturn; i++)
		{
			yield return array[i];
		}
	}

	public static ICollection<T> GetAllPaged<T>(PageGetterLong<T> pagedGetter, long startRow, long maxRowsPerPage)
	{
		if (pagedGetter == null || startRow < 0 || maxRowsPerPage < 1)
		{
			throw new ArgumentException();
		}
		List<T> list = new List<T>();
		ICollection<T> collection;
		do
		{
			collection = pagedGetter(startRow, maxRowsPerPage);
			list.AddRange(collection);
			startRow += maxRowsPerPage;
		}
		while (collection.Count == maxRowsPerPage);
		return list;
	}

	public static ICollection<T> GetAllPaged<T>(PageGetterInt<T> pagedGetter, int startRow, int maxRowsPerPage)
	{
		return GetAllPaged((long arg1, long arg2) => pagedGetter((int)arg1, (int)arg2), startRow, maxRowsPerPage);
	}

	public static ICollection<T> GetAllPaged<T>(PageGetterLong<T> pagedGetter, long maxRowsPerPage)
	{
		return GetAllPaged(pagedGetter, 0L, maxRowsPerPage);
	}

	public static ICollection<T> GetAllPaged<T>(PageGetterInt<T> pagedGetter, int maxRowsPerPage)
	{
		return GetAllPaged(pagedGetter, 0, maxRowsPerPage);
	}

	public static ICollection<T> GetPagedWithIterationBound<T>(PageGetterLong<T> pagedGetter, long maxRowsPerPage, int inclusiveCapOnNumberOfIterations)
	{
		if (pagedGetter == null || maxRowsPerPage < 1)
		{
			throw new ArgumentException();
		}
		List<T> list = new List<T>();
		long num = 0L;
		int num2 = 0;
		ICollection<T> collection;
		do
		{
			collection = pagedGetter(num, maxRowsPerPage);
			list.AddRange(collection);
			num += maxRowsPerPage;
			num2++;
		}
		while (collection.Count == maxRowsPerPage && num2 < inclusiveCapOnNumberOfIterations);
		return list;
	}

	public static ICollection<T> GetPagedWithIterationBound<T>(PageGetterInt<T> pagedGetter, int maxRowsPerPage, int inclusiveCapOnNumberOfIterations)
	{
		return GetPagedWithIterationBound((long start, long max) => pagedGetter((int)start, (int)max), maxRowsPerPage, inclusiveCapOnNumberOfIterations);
	}
}
