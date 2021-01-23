using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey, Tvalue>
    {
        TKey[] keys;
        Tvalue[] values;


        public MyDictionary()
        {

            keys = new TKey[0];
            values = new Tvalue[0];
        }

        public void Add(TKey key, Tvalue value)
        {
            TKey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

       

        public int Length
        {
            get { return keys.Length; }
            
        }
       

        public TKey[] Keys
        {
            get { return keys; }
            
        }
        

        public Tvalue[] Values
        {
            get { return values; }
           
        }


    }
}
