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

    [SerializeField] TMP_Text countdownText;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de ShopManager dans la scène");
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
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("000.00");


        /*if (currentTime <= 14)
        {
            LaMusic.PlayOneShot(clip);
        }*/

        if (currentTime <= 0)
        {
            currentTime = 0;
            PlayerHealth.instance.Die();
            Debug.Log("Player is Kablewy");
        }
    }
}
