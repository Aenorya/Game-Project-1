using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorScript : MonoBehaviour
{
    public static ButtonDoorScript instance;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerNotTrigger"))
        {
            Debug.Log("Ca devient vrai");
            PlayerController.instance.doorButtonIsPressed = true;
        }
    }
}
