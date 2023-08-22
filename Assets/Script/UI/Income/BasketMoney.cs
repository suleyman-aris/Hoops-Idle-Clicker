using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketMoney : MonoBehaviour
{
    public static BasketMoney basketMoney;

    public List<float> floatList = new List<float> { 1f, 5f, 10f, 25f };
    List<float> tempList = new List<float> { 1f, 5f, 10f, 25f };

    private string save;

    private void Awake()
    {
        basketMoney = basketMoney == null ? this : basketMoney;
    }

    private void Start()
    {
        transform.GetComponent<EnoughMoney>().CanInteract = true;

        for (int i = 0; i < floatList.Count; i++)
        {
            save = transform.name + SceneManager.GetActiveScene().buildIndex.ToString() + i.ToString();
            if (PlayerPrefs.HasKey(save))
            {
                floatList[i] = PlayerPrefs.GetFloat(save);
            }
            else
                break;
        }
    }

    public void MultiplyListValues(float multiplier)
    {
        for (int i = 0; i < floatList.Count; i++)
        {
            save = transform.name + SceneManager.GetActiveScene().buildIndex.ToString() + i.ToString();
            floatList[i] = Mathf.RoundToInt(floatList[i] + tempList[i]);
            PlayerPrefs.SetFloat(save, floatList[i]);
        }
    }
}
