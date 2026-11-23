using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public static class Utils
{
    #region Random function
    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0)
            return default(T);

        return array[Random.Range(0, array.Length)];
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
    #endregion
}
