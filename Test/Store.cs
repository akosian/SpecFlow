using System;
using System.Collections.Generic;

namespace Test
{
    public class Store
    {
        private static Dictionary<string, Object> store =  new Dictionary<string, Object>();

        public static void put(string key, Object value)
        {
            store.Add(key, value);
        }

        public static Object get(string key)
        {
           return store.GetValueOrDefault(key);
        }
    }
}