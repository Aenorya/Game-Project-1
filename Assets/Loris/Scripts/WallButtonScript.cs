using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class WallButtonScript : MonoBehaviour
{
    //public BoxSpawn boxSpawn;
    public PlayerController playerController;


    public static WallButtonScript instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Wall Button dans la scène");
            return;
        }
        instance = this;
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        playerController.Interact();
    }*/

    public virtual void OnInteraction()
    {
        BoxSpawn.instance.SpawnBox();
    }
}
