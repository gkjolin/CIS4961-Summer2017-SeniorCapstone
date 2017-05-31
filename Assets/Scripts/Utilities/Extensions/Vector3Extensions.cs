﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Extensions
{
    public static float SqrDistance(this Vector3 source, Vector3 destination)
    {
        var differenceVector = destination - source;
        return differenceVector.sqrMagnitude;
    }
}
