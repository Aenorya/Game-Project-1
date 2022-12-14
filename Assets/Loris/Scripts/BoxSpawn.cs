using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{

    public static BoxSpawn instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerMovement dans la scène");
            return;
        }
        instance = this;
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
