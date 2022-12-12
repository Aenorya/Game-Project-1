using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableEnvironementScript : MonoBehaviour
{
    public GameObject Destroyable;
    public BoxCollider2D boxCollider;
    public PickableObject itemDrop;

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
            Vector3 dropPos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            GetComponent<InventoryFinalVersion>().InstantiateLoot(dropPos);
            Destroy(Destroyable);
            boxCollider.enabled = false;
        }
    }
}
