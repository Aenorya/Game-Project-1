using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorScript : MonoBehaviour
{
    public ButtonDoorScript instance;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.instance.bombButtonIsPressed = true;
        }
    }
}
