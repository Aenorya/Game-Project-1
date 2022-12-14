using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Pickable Collection")]
public class PickableCollection : ScriptableObject
{
    public List<DropRate> drops;
}

[Serializable]
public class DropRate
{
    [Range(0,100)]
    public int rate;
    public PickableObject pickable;
}
