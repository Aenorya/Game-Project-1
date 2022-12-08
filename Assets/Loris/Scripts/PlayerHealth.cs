using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //public int maxHealth = 100;
    //public int currentHealth;

    public float invincibilityTimeAfterHit = 3f;
    public float invincibilityFlashDelay = 0.2f;
    public bool isInvincible = false;

    public SpriteRenderer graphics;
    public List<GameObject> hearts;
    public int hp;

    public AudioClip hitSound;

    public PlayerController playerController;
    
    public static PlayerHealth instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
    }

    void Start()
    {
        hp = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Hurt();
        }
    }

    public void HealPlayer()
    {
        if(hp >= 3)
        {
            hp = 3;
        }
        else
        {
            hp ++;
        }

    }
    public void Hurt()
    {
        if (hp <= 0)
        {
            hp = 0;
            //Invoke("Die", 1);
            playerController.Die();
        }
        else
        {
            hp--;
            hearts[hp].GetComponent<Image>().color = Color.black;
        }
    }


    /*public void TakeDamage()
    {
        if (!isInvincible)
        {
            AudioManager.instance.PlayClipAt(hitSound, transform.position);
            healthBar.Hurt();

            if(healthBar.hp <= 0)
            {
                Die();
                return;
            }

            isInvincible = true;
            StartCoroutine(InvincibilityFlash());
            StartCoroutine(HandleInvincibilityDelay());
        }
    }*/

    public IEnumerator InvincibilityFlash()
    {
        while (isInvincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(invincibilityFlashDelay);
        }
    }

    public IEnumerator HandleInvincibilityDelay()
    {
        yield return new WaitForSeconds(invincibilityTimeAfterHit);
        isInvincible = false;
    }
}
