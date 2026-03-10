using System;
using System.Collections.Generic;

class DataProcessor
{
    private int[] _data = new int[50];

    public DataProcessor(int[] i)
    {
        _data = i;
    }

    public void ForEach(Action<int> action)
    {
        foreach (int i in _data)
        {
            action(i);
        }
    }

    public List<int> Transform(Func<int, int> transformer)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < _data.Length; i++)
        {
            result.Add(_data[i] * 2);
        }

        return result;
    }

    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> result = new List<int>();

        foreach (int i in _data)
        {
            if (predicate(i))
            {
                result.Add(i);
            }
        }

        return result;
    }

    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        foreach (int i in _data)
        {
            initialValue = reducer(i, initialValue);
        }

        return initialValue;
    }
}