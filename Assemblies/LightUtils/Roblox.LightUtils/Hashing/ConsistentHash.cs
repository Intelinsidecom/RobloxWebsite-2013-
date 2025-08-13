using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.LightUtils
{
    public class ConsistentHash<T>
    {
        public void Init(IEnumerable<T> nodes)
        {
            Init(nodes, _Replicate);
        }
        public void Init(IEnumerable<T> nodes, int replicate)
        {
            _Replicate = replicate;
            foreach (T node in nodes)
            {
                Add(node, false);
            }
            _AyKeys = _Circle.Keys.ToArray();
        }
        public void Add(T node)
        {
            Add(node, true);
        }
        private void Add(T node, bool updateKeyArray)
        {
            for (int i = 0; i < _Replicate; i++)
            {
                _Circle[BetterHash(node.GetHashCode().ToString() + i)] = node;
            }
            if (updateKeyArray)
            {
                _AyKeys = _Circle.Keys.ToArray();
            }
        }
        public void Remove(T node)
        {
            for (int i = 0; i < _Replicate; i++)
            {
                if (!_Circle.Remove(BetterHash(node.GetHashCode().ToString() + i)))
                {
                    throw new Exception("can not remove a node that not added");
                }
            }
            _AyKeys = _Circle.Keys.ToArray();
        }

        private int First_ge(int[] ay, int val)
        {
            int idx = 0;
            int ayiter = ay.Length - 1;
            if (ay[ayiter] < val || ay[0] > val)
            {
                return 0;
            }
            while (ayiter - idx > 1)
            {
                int num3 = (ayiter + idx) / 2;
                if (ay[num3] >= val)
                {
                    ayiter = num3;
                }
                else
                {
                    idx = num3;
                }
            }
            if (ay[idx] > val || ay[ayiter] < val)
            {
                throw new Exception("should not happen");
            }
            return ayiter;
        }
        public T GetNode(string key)
        {
            return _Circle[_AyKeys[First_ge(_AyKeys, BetterHash(key))]];
        }
        public static int BetterHash(string key)
        {
            return (int)MurmurHash2.Hash(Encoding.ASCII.GetBytes(key));
        }

        private int _Replicate = 100;
        private int[] _AyKeys;
        private readonly SortedDictionary<int, T> _Circle = new SortedDictionary<int, T>();
    }
}
