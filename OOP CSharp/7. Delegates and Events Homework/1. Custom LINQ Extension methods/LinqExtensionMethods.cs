using System;
using System.Collections.Generic;

public static class LinqExtensionMethods
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var element in collection)
        {
            if (!predicate(element))
                result.Add(element);
        }
        return result;
    }

    public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> condition)
    {
        List<TSelector> result = new List<TSelector>();
        foreach (var source in collection)
        {
            //TSelector a = condition(source);
            result.Add(condition(source));
        }
        result.Sort();
        return result[result.Count - 1];
    }
}
