using System;
using System.Collections;
using System.Collections.Generic;

namespace Roblox.Collections;

public class CircularBuffer<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ICollection<T>
{
	private T[] _Buffer;

	private int _Head;

	private int _Tail;

	public int Count { get; private set; }

	public bool IsReadOnly => false;

	public int Capacity
	{
		get
		{
			return _Buffer.Length;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", "must be positive");
			}
			if (value != _Buffer.Length)
			{
				T[] buffer = new T[value];
				int count = 0;
				while (Count > 0 && count < value)
				{
					buffer[count++] = Dequeue();
				}
				_Buffer = buffer;
				Count = count;
				_Head = count - 1;
				_Tail = 0;
			}
		}
	}

	public T this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return _Buffer[(_Tail + index) % Capacity];
		}
		set
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			_Buffer[(_Tail + index) % Capacity] = value;
		}
	}

	public CircularBuffer(int capacity)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", "must be positive");
		}
		_Buffer = new T[capacity];
		_Head = capacity - 1;
	}

	public bool Remove(T item)
	{
		int pos = IndexOf(item);
		if (pos == -1)
		{
			return false;
		}
		RemoveAt(pos);
		return true;
	}

	public T Enqueue(T item)
	{
		_Head = (_Head + 1) % Capacity;
		T result = _Buffer[_Head];
		_Buffer[_Head] = item;
		if (Count == Capacity)
		{
			_Tail = (_Tail + 1) % Capacity;
			return result;
		}
		int count = Count + 1;
		Count = count;
		return result;
	}

	public T Dequeue()
	{
		if (Count == 0)
		{
			throw new InvalidOperationException("queue exhausted");
		}
		T result = _Buffer[_Tail];
		_Buffer[_Tail] = default(T);
		_Tail = (_Tail + 1) % Capacity;
		int count = Count - 1;
		Count = count;
		return result;
	}

	public void Add(T item)
	{
		Enqueue(item);
	}

	public void Clear()
	{
		_Head = Capacity - 1;
		_Tail = 0;
		Count = 0;
	}

	public bool Contains(T item)
	{
		return IndexOf(item) != -1;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		for (int i = 0; i < Count; i++)
		{
			T element = this[i];
			array[arrayIndex] = element;
			arrayIndex++;
		}
	}

	public int IndexOf(T item)
	{
		for (int i = 0; i < Count; i++)
		{
			if (object.Equals(item, this[i]))
			{
				return i;
			}
		}
		return -1;
	}

	public void Insert(int index, T item)
	{
		if (index < 0 || index > Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (Count == index)
		{
			Enqueue(item);
			return;
		}
		T last = this[Count - 1];
		for (int i = index; i < Count - 2; i++)
		{
			this[i + 1] = this[i];
		}
		this[index] = item;
		Enqueue(last);
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		for (int i = index; i > 0; i--)
		{
			this[i] = this[i - 1];
		}
		Dequeue();
	}

	public IEnumerator<T> GetEnumerator()
	{
		if (Count != 0 && Capacity != 0)
		{
			int i = 0;
			while (i < Count)
			{
				yield return this[i];
				int num = i + 1;
				i = num;
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
