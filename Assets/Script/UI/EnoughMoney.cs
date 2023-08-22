using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnoughMoney : TextPrint
{
    private int enough;

    public bool CanInteract = true;

    Button button;

    public int startPrice;
    public float increasePrice = 5;
    public int clickCount;

    private string clickCountSave;

    // Start is called before the first frame update
    void Awake()
    {
        clickCountSave = transform.name + SceneManager.GetActiveScene().buildIndex.ToString();
        if (PlayerPrefs.HasKey(clickCountSave))
        {
            clickCount = PlayerPrefs.GetInt(clickCountSave);
        }
        NewPrice();
        button = transform.GetComponent<Button>();
        button.onClick.AddListener(DecreaseMoney);
        button.onClick.AddListener(NewPrice);
    }

    public void OtherQualification()
    {
        CanInteract = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoneyManager.moneyManager.totalMoney >= enough && CanInteract)
        {
            transform.GetComponent<ButtonActive>().ActiveButton();
        }
        else
        {
            transform.GetComponent<ButtonActive>().DeActivateButton();
        }
    }

    private void NewPrice()
    {
        enough = CalculatePrice(startPrice, increasePrice, clickCount);
        string moneyPrint = enough.ToString();

        ButtonPrint(System.Convert.ToInt64(enough));
        PlayerPrefs.SetInt(clickCountSave, clickCount);       
        clickCount += 1;
    }

    private void DecreaseMoney()
    {
        MoneyManager.moneyManager.DecreaseTotalMoney(enough);
    }

    public int CalculatePrice(int startPrice, float increasePrice, int clickCount)
    {        
        return startPrice + (int)(increasePrice * clickCount);
    }
}
