using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugExample : MonoBehaviour
{
    private List<int> _numbers;

    private void Awake()
    {
        DebugClass debugClass = new DebugClass();
        debugClass.Add(0);

        _numbers = new List<int>();
        _numbers.Add(0);
    }
}
