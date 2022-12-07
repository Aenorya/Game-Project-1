using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PickableObject : ScriptableObject
{
    public Sprite poSprite;
    public string poName;
    public int dropChance;
    public GameObject poPrefab;
}
