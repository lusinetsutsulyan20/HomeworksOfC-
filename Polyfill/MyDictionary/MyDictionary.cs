    using System;
    using System.Collections.Generic;
    using System.Net.WebSockets;
    using Couples;
    namespace MyDic
    {
    public class Dictionary<Tkey, Tvalue>
    {
        public int Count {get; private set;}
        private int _capacity = 2;
        public Couple<Tkey, Tvalue>[] _array;

        public Dictionary ()
        {
            _array = new Couple<Tkey, Tvalue>[_capacity];
        }

        public Tvalue this[Tkey key]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    if (key!.Equals(_array[i].Key))
                    {
                        return _array[i].Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                for (int i = 0; i < Count; i++)
                {
                    if (key!.Equals(_array[i].Key))
                    {
                        _array[i].Value = value;
                        return;
                    }
                }
                throw new KeyNotFoundException();
            }
        }


        public void Add(Tkey key, Tvalue value)
        {
            if (ContainsKey(key) || ContainsValue(value)){
                Console.WriteLine("Array already has that item");
                return;
            }
            if (Count == _capacity)
            {
                Resize();
            }
            _array[Count] = new Couple<Tkey, Tvalue>(key, value);
            ++Count;
        }

        private void Resize()
        {
            _capacity *= 2;
            Couple<Tkey, Tvalue>[] tmp = new Couple<Tkey, Tvalue>[_capacity];
            for (int i = 0; i < Count; i++)
            {
                tmp[i] = _array[i];
            }
            _array = tmp;
        }

        
        public bool ContainsKey (Tkey key)
        {
            foreach (var item in _array)
            {
                if (key!.Equals(item.Key))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsValue (Tvalue value)
        {
            foreach (var item in _array)
            {
                if (value!.Equals(item.Value))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove (Tkey key)
        {
            for (int i = 0; i < Count; i++)
                {
                if (key!.Equals(_array[i].Key))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                    _array[--Count] = default!;
                    return true;
                }
            }
            return false;   
        }


    }
    }
