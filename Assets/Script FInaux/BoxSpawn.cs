using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{

    public static BoxSpawn instance;

    private void Awake()
    {
        SpawnBox();
    }

    public void SpawnBox()
    {
        GameObject box = GameObject.FindGameObjectWithTag("ReBox");
        if (box)
        {
            box.transform.position = transform.position;
        }
    }
}
