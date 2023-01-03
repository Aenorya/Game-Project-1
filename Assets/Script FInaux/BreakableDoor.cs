using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableDoor : MonoBehaviour
{
    private float fakeHealth = 1;


    public void HitDoor(float amount)
    {
        fakeHealth -= amount;
        if (fakeHealth == 0)
        {
            Invoke("DestroyDoor", 0.1f); //temps de l'animation
        }
    }
    public void DestroyDoor()
    {
        Destroy(gameObject);
    }
}
