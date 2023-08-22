using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class TextPrint : MonoBehaviour
{
    public virtual void ButtonPrint(float amount)
    {
        if (amount >= 1000000000)
        {
            float money = (float)amount / 1000000000;
            transform.GetChild(0).GetComponent<Text>().text = money.ToString("F1") + " b";
        }
        else if (amount >= 1000000)
        {
            float money = (float)amount / 1000000;
            transform.GetChild(0).GetComponent<Text>().text = money.ToString("F1") + " m";
        }
        else if (amount >= 1000)
        {
            float money = (float)amount / 1000;
            transform.GetChild(0).GetComponent<Text>().text = money.ToString("F1") + " k";
        }
        else
        {
            transform.GetChild(0).GetComponent<Text>().text = amount.ToString();
        }
    }
}
