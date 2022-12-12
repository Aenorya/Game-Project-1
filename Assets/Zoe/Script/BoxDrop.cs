using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDrop : MonoBehaviour
{
    public static BoxDrop instance;

    private float fakeHealth = 1;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de BoxDrop dans la scène");
            return;
        }
        instance = this;
    }
    public void HitBox(float amount)
    {
        fakeHealth -= amount;
        if(fakeHealth == 0)
        {
            Vector3 dropPos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            GetComponent<InventoryFinalVersion>().InstantiateLoot(dropPos);
            Invoke("DestroyBox", 0.1f);
        }
    }

    public void DestroyBox()
    {
        Destroy(gameObject);
    }
}
