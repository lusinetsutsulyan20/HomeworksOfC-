using System;
namespace Couples
{
public class Couple <TKey, TValue>
{
    public TKey Key {get; set;}
    public TValue Value {get; set;}
    
    public Couple (TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}
}
