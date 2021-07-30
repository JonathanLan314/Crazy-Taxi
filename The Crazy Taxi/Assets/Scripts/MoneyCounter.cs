using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    public Text moneyCounter;
    public float tip;

    void Start()
    {
        moneyCounter.text = "MONEY = 0$";
    }

    void Update()
    {
        tip = Mathf.Round(tip * 10.0f) * 0.1f;
        moneyCounter.text = "MONEY = " + tip + "$";
    }
}
