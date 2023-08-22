using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int enoughMoney;

    private Button nextLevel;

    private void OnEnable()
    {
        nextLevel = transform.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MoneyManager.moneyManager.totalMoney >= enoughMoney)
        {
            nextLevel.interactable = true;
        }
        else if (MoneyManager.moneyManager.totalMoney <= enoughMoney)
        {
            nextLevel.interactable = false;
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
