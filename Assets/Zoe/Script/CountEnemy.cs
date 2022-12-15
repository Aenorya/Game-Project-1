using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountEnemy : MonoBehaviour
{
    public int numberEnemy;
    public TextMeshProUGUI textNbEnemy;

    public static CountEnemy instance;

    public void Awake()
    {
        instance = this;
    }
    
    void Update()
    {
        textNbEnemy.text = numberEnemy + " x";
    }
}
