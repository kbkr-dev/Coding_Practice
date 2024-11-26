using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Practice
{
    public class HashTable<TKey,  TValue>
    {
        private readonly LinkedList<KeyValuePair<TKey, TValue>>[] data;
        private readonly int _size;

        public HashTable(int size = 100)
        {
            _size = size;
            data = new LinkedList<KeyValuePair<TKey, TValue>>[size];
        }

        public int DataIndex(TKey key)
        {
            int asd = key.GetHashCode();
            return Math.Abs(key.GetHashCode() & 0x7FFFFFFF % _size);
        }

        public void AddData(TKey key, TValue value)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));


            int existKey = DataIndex(key);

            if (data[existKey] == null)
            {
                data[existKey] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            foreach(var pair in data[existKey])
            {
                if(EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                {
                    throw new ArgumentException("An item with the same key exist");
                }
            }

            data[existKey].AddLast(new KeyValuePair<TKey, TValue>(key, value));
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            int existKey = DataIndex(key);

            if (data[existKey] != null)
            {
                foreach(var pair in data[existKey])
                {
                    if(EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                    {
                        value = pair.Value;
                        return true;
                    }
                }
            }

            value = default;
            return false;
        }

        public bool Remove(TKey key)
        {
            int existKey = DataIndex(key);

            if (data[existKey] != null)
            {
                var node = data[existKey].First;
                while (node != null)
                {
                    if(EqualityComparer<TKey>.Default.Equals(node.Value.Key, key))
                    {
                        data[existKey].Remove(node);
                        return true;
                    }

                    node = node.Next;
                }
            }

            return false;
        }
    }
}
