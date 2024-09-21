using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugClass
{
    private List<int> _numbers = new();

   public void Add(int number)
    {
        _numbers.Add(number);
    }
}
