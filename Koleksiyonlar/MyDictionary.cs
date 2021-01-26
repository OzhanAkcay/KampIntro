using System;
using System.Collections.Generic;
using System.Text;

namespace Koleksiyonlar
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempArrayKey = keys;
            keys = new Key[keys.Length + 1];
            Value[] tempArrayValue = values;
            values = new Value[values.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
            }
            keys[keys.Length - 1] = key;
            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                values[i] = tempArrayValue[i];
            }
            values[values.Length - 1] = value;
            Console.WriteLine(key + " " + value + " ");
        }
    }
}
