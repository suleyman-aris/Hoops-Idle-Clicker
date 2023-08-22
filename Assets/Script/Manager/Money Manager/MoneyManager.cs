using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyManager : TextPrint
{
    public float totalMoney = 0;

    public static MoneyManager moneyManager;

    private string totalMoneyString;

    private void Awake()
    {
        moneyManager = moneyManager == null ? this : moneyManager;
    }

    private void Start()
    {
        totalMoneyString = "totalMoney" + SceneManager.GetActiveScene().buildIndex.ToString();
        if (PlayerPrefs.HasKey(totalMoneyString))
        {
            InreaseTotalMoney(PlayerPrefs.GetFloat(totalMoneyString));
        }
    }

    public void InreaseTotalMoney(float otherMoney)
    {
        totalMoney += (float)otherMoney;
        PlayerPrefs.SetFloat(totalMoneyString, totalMoney);
        PlayerPrefs.Save();
        ButtonPrint(totalMoney);
    }

    public void DecreaseTotalMoney(float otherMoney)
    {
        totalMoney -= (float)otherMoney;
        ButtonPrint(totalMoney);
    }
}