using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableEnvironementScript : MonoBehaviour
{
    public GameObject Destroyable;
    public BoxCollider2D boxCollider;

    public static DestroyableEnvironementScript instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            Destroy(Destroyable);
            boxCollider.enabled = false;
        }
    }
}
