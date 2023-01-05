using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //public AudioClip clip;
    //public AudioSource LaMusic;

    float currentTime = 0f;
    public float startingTime;
    public static Timer instance;

    public bool BombButtonTimer;

    [SerializeField] TMP_Text countdownText;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de ShopManager dans la sc�ne");
            return;
        }
        instance = this;
    }

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        if (BombButtonTimer == false)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = string.Format("{0:00} : {1:00}",  (int)currentTime/60, (int)currentTime%60);
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            PlayerHealth.instance.Hurt();
            PlayerHealth.instance.Hurt();
            PlayerHealth.instance.Hurt();
            Debug.Log("Player is Kablewy");
        }
    }
}
