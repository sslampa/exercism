using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach(var c in collection)
        {
            var tmp = func(c);
            yield return tmp;
        }
    }
}