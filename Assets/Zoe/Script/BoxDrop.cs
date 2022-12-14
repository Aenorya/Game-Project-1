using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDrop : MonoBehaviour
{
    private float fakeHealth = 1;

    
    public void HitBox(float amount)
    {
        fakeHealth -= amount;
        if(fakeHealth == 0)
        {
            Vector3 dropPos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            GetComponent<Droper>().InstantiateLoot(dropPos);
            Invoke("DestroyBox", 0.1f);
        }
    }

    public void DestroyBox()
    {
        Destroy(gameObject);
    }
}
