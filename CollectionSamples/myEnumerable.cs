using CollectionSamples.Dictionary;
using System.Collections;

public class MyEnumerable<T> : IEnumerable<T>
{
    private T[] _items;

    public MyEnumerable(T[] items)
    {
        _items = items;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _items.Length; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
public class MyDictionaryEnumerable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private readonly myDictionary<TKey, TValue> _dictionary;

    public MyDictionaryEnumerable(myDictionary<TKey, TValue> dictionary)
    {
        _dictionary = dictionary;
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return new MyDictionaryEnumerator<TKey, TValue>(_dictionary);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
public class MyDictionaryEnumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>
{
    private readonly myDictionary<TKey, TValue> _dictionary;
    private int _currentIndex = -1;
 


    public MyDictionaryEnumerator(myDictionary<TKey, TValue> dictionary)
    {
        _dictionary = dictionary;
    }

    public bool MoveNext()
    {
        _currentIndex++;
        return _currentIndex < _dictionary.Count;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    public KeyValuePair<TKey, TValue> Current => new KeyValuePair<TKey, TValue>(_dictionary.Keys.ElementAt(_currentIndex), _dictionary[_dictionary.Keys.ElementAt(_currentIndex)]);

    object IEnumerator.Current => Current;

    public void Dispose() { }
}
