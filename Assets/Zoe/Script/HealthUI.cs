using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image filler;
    public Image[] states;
    public Gradient gradient;

    public static HealthUI instance;

    public void Awake()
    {
        instance = this;
    }

    public void ChangeLife(float currentHP)
    {
        filler.fillAmount = currentHP;
        filler.color = gradient.Evaluate(currentHP);
    }
}
