using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonRespawnBox : MonoBehaviour
{
    //public BoxSpawn boxSpawn;
    public PlayerController playerController;
    public Collider2D capsuleCollider;

    public virtual void OnInteraction()
    {
            BoxSpawn.instance.SpawnBox(); 
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController.instance.inContact = true;
        }
    }


}
