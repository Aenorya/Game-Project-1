using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombButtonScript : MonoBehaviour
{
    public static BombButtonScript instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de bomb Button dans la scène");
            return;
        }
        instance = this;
    }

    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.instance.BombButtonIsPressed = true;
        }
    }
}
