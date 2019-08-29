using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Extension
{
    public static bool IsEqualTo(this Color my, Color other)
    {
        return ColorUtility.ToHtmlStringRGBA(my) == ColorUtility.ToHtmlStringRGBA(other);
    }
}
