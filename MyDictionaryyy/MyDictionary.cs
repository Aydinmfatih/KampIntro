using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryyy
{

  

    

    internal class MyDictionary<Key,Value>  
    {
    Key[] _key;
    Value[] _value;
    Key[] _keyTempArray;
    Value[] _valueTempArray;


        public MyDictionary()
        {
            _key= new Key[0];
            _value= new Value[0];   
        }
        public void Add(Key key, Value value) {

            _keyTempArray = _key;
            _valueTempArray = _value;

            _key = new Key[_key.Length + 1];
            _value=new Value[_value.Length + 1];

            for (int i = 0; i < _keyTempArray.Length; i++)
            {
                _key[i] = _keyTempArray[i];
                _value[i] = _valueTempArray[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
    }
}
