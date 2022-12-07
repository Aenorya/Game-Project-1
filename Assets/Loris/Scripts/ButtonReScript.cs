using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonReScript : MonoBehaviour
{
    public BoxSpawn boxSpawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            boxSpawn.SpawnBox();
        }
    }
}
