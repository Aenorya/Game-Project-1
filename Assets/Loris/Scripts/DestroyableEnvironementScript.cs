using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableEnvironementScript : MonoBehaviour
{
    public GameObject Destroyable;
    public BoxCollider2D boxCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            Destroy(Destroyable);
            boxCollider.enabled = false;
        }
    }
}
