
using System;
namespace MyStack;
public class MyStack <T>
{
    T[] _array;
    public int Count {get; private set;}
    private int _capacity = 2;

    public MyStack ()
    {
        _array = new T[_capacity];
    }

    public void Push (T item)
    {
        if (Count == _capacity)
        {
            Resize();
        }
        _array[Count] = item;
        ++Count;
    }    
    
    public void Resize()
    {
        _capacity *= 2;
        T[] tmp = new T[_capacity];

        for (int i = 0; i < _array.Length; i++)
        {
            tmp[i] = _array[i];
        }
        _array = tmp;
    }

    public void Pop()
    {
        _array[Count - 1] = default;
        --Count;
    }

    public string Peek()
    {
        return _array[Count - 1].ToString();
    }
}