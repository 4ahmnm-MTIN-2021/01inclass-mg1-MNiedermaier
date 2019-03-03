﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    void Update()
    {
        // Move the object upward in world space 1 unit/second.
        transform.Translate(0, Time.deltaTime * -1, 0, Space.World);
    }
}

