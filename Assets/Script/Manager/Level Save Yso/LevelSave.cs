using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSave : MonoBehaviour
{
    private bool level1 = false;
    private bool level2 = false;

    private int levelNumber;
    private void Awake()
    {
        if (PlayerPrefs.GetString("level1") == "true")
        {
            level1 = true;
        }
        if (PlayerPrefs.GetString("level2") == "true")
        {
            level2 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        levelNumber = SceneManager.GetActiveScene().buildIndex;
        if (levelNumber == 1 && !level1)
        {
            level1 = true;
            PlayerPrefs.SetString("level1", "true");
            YsoCorp.GameUtils.YCManager.instance.OnGameStarted(levelNumber);
        }
        else if(levelNumber == 2 && !level2)
        {
            YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);
            level2 = true;
            PlayerPrefs.SetString("level2", "true");
            YsoCorp.GameUtils.YCManager.instance.OnGameStarted(levelNumber);
        }
        else if (levelNumber == 2 && MoneyManager.moneyManager.totalMoney > 2000000)
        {
            YsoCorp.GameUtils.YCManager.instance.OnGameFinished(true);
        }
    }
}
