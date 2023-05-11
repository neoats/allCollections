namespace CollectionSamples.Dictionary;

public class myDictionary<TKey, TValue>
{
    readonly Dictionary<TKey, TValue> _dict;

    public myDictionary()
    {
        _dict = new Dictionary<TKey, TValue>();
    }


    public TValue this[TKey key]
    {
        get => _dict[key];
        set => _dict[key] = value;
    }


    public int Count => _dict.Count;
    public IEnumerable<TKey> Keys => _dict.Keys;

    public void Add(TKey key, TValue value)
    {
        if (_dict.ContainsKey(key)) Console.WriteLine("item already exists");

        _dict.Add(key, value);
    }

    public void RemoveValue(TValue value)
    {
        var keys = new List<TKey>();
        foreach (var item in _dict)
            if (item.Value.Equals(value))
                keys.Add(item.Key);
        foreach (var key in keys) _dict.Remove(key);
    }

    public bool ContainsKey(TKey key)
    {
        foreach (var pair in _dict)
            if (pair.Key.Equals(key))
                return true;
        return false;
    }

    public bool ContainsValue(TValue value)
    {
        foreach (var pair in _dict)
            if (pair.Value.Equals(value))
                return true;
        return false;
    }

    public void Clear()
    {
        new List<KeyValuePair<TKey, TValue>>();
    }

    public void PrintDictionary()
    {
        Console.WriteLine("{ ");
        foreach (var item in _dict) Console.WriteLine($"[{item.Key}: {item.Value}], ");
        Console.WriteLine("}");
    }
}