using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float invincibilityTimeAfterHit = 3f;
    public float invincibilityFlashDelay = 0.2f;
    public bool isInvincible = false;

    public SpriteRenderer graphics;
    public int maxHealth = 3;
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
        hp = maxHealth;
        HealthUI.instance.ChangeLife(1f);
    }

    void Update()
    {
        
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
            //hearts[hp-1].GetComponent<Image>().color = Color.white;
        }
        HealthUI.instance.ChangeLife((float)hp / maxHealth);

    }
    public void Hurt()
    {
        hp--;
        HealthUI.instance.states[hp + 1].gameObject.SetActive(false);
        HealthUI.instance.states[hp].gameObject.SetActive(true);
        if(hp == 0)
        {
            PlayerController.instance.Die();
        }
        HealthUI.instance.ChangeLife((float)hp / maxHealth);

    }
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
