using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    private void Awake()
    {
        SpawnBox();
    }

    public void SpawnBox()
    {
        GameObject.FindGameObjectWithTag("ReBox").transform.position = transform.position;
    }
}
