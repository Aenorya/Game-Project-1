using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptTest : MonoBehaviour
{
    private float range;
    private Transform target;
    public float minDistance = 5.0f;
    private bool targetCollision = false;
    private float speed = 2.0f;
    private float thrust = 1.5f;
    public static float health = 5;
    private int hitStrength = 1;

    public Sprite deathSprite;
    public Sprite[] sprites;

    private CurrentSceneManager gameManager;

    private bool isDead = false;

    public PlayerHealth playerHealth;

    public static EnemyScriptTest instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de EnemyScript dans la scène");
            return;
        }
        instance = this;
    }

    void Start()
    {
        gameManager = GetComponent<CurrentSceneManager>();
        int rnd = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[rnd];
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);
        if (range < minDistance && !isDead)
        {
            if (!targetCollision)
            {
                // Get the position of the player
                transform.LookAt(target.position);

                // Correct the rotation
                transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }
        transform.rotation = Quaternion.identity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !targetCollision)
        {
            Vector3 contactPoint = collision.contacts[0].point;
            Vector3 center = collision.collider.bounds.center;

            targetCollision = true;

            bool right = contactPoint.x > center.x;
            bool left = contactPoint.x < center.x;
            bool top = contactPoint.y > center.y;
            bool bottom = contactPoint.y < center.y;

            if (right) GetComponent<Rigidbody2D>().AddForce(transform.right * thrust, ForceMode2D.Impulse);
            if (left) GetComponent<Rigidbody2D>().AddForce(-transform.right * thrust, ForceMode2D.Impulse);
            if (top) GetComponent<Rigidbody2D>().AddForce(transform.up * thrust, ForceMode2D.Impulse);
            if (bottom) GetComponent<Rigidbody2D>().AddForce(-transform.up * thrust, ForceMode2D.Impulse);
            Invoke("FalseCollision", 0.5f);

            playerHealth.Hurt();
        }
    }

    void FalseCollision()
    {
        targetCollision = false;
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            isDead = true;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<SpriteRenderer>().sprite = deathSprite;
            GetComponent<SpriteRenderer>().sortingOrder = -1;
            //GetComponent<Collider2D>().enabled = false;
            Invoke("EnemyDeath", 0.5f);
        }
        
    }

    void EnemyDeath()
    {
        Vector3 dropPos = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        GetComponent<InventoryFinalVersion>().InstantiateLoot(dropPos);
        //gameManager.SetMobCount(-1);
        Invoke("Destroy", 0.5f);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public int GetHitStrength()
    {
        return hitStrength;
    }
}

