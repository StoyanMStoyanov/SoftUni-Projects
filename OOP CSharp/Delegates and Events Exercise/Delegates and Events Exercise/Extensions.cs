using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> condition)
    {
        List<T> result = new List<T>();
        foreach (var element in collection)
        {
            if (condition(element)) return element;
        }
        return default(T);
    }

    public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection,
        Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var element in collection)
        {
            if(!predicate(element)) break;
            result.Add(element);
        }
        return result;
    }

    public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
    {
        foreach (var element in collection)         
            action(element);         
    }
}
