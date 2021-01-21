using System;
using System.Collections.Generic;
using System.Text;

namespace Example_3_1
{
    class MyDictionary<K, V>
    {

        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] _tempKeyArray = keys;
            V[] _tempValArray = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                keys[i] = _tempKeyArray[i];
                values[i] = _tempValArray[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void Add(K key)
        {
            K[] _tempKeyArray = keys;
            V[] _tempValArray = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                keys[i] = _tempKeyArray[i];
                values[i] = _tempValArray[i];
            }
            keys[keys.Length - 1] = key;
            
        }

        public void PrintValues()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ", " + values[i]);
            }

        }
    }
}
