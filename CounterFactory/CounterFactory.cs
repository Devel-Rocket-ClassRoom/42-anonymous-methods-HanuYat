using System;

class CounterFactory
{
    private static int _count = 0;

    public static Func<int> CreateSimpleCounter = () =>
    {
        int count = _count++;        
        return count;
    };

    public static Func<int, int> CreateStepCounter = (int step) =>
    {
        _count += step;
        return _count;
    };

    //public static Func<int> CreateBoundedCounter(int min, int max)
    //{
    //    return () =>
    //    {
    //        for (int i = min; i <= max; i++)
    //        {              
    //            return _count++;
    //        }
    //    };
    //}

    public static void CreateResettableCounter()
    {
        Action reset = () => _count = 0;

        Func<int> count = () =>
        {
            _count++;
            return _count;
        };
    }
}