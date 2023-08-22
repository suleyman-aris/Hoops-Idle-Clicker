using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeMachine : MonoBehaviour
{
    private Button mergeButton;
    private List<GameObject> firstLevelObjects;
    public bool mergeEnabled = false;
    private Button addButton;
    public int merge�ndex;

    // Start is called before the first frame update
    void Awake()
    {
        addButton = GameObject.Find("Add Man").GetComponent<Button>();
        mergeButton = GameObject.Find("Merge Man").GetComponent<Button>();
        MergeEnabled();
    }
    private void Start()
    {
        ButtonClicked();
    }

    public void ButtonClicked()
    {
        mergeEnabled = false;
        for (merge�ndex = 1; merge�ndex < 4; merge�ndex++)
        {
            if (MatchList.matchList.levelObjects[merge�ndex].Count >= 2)
            {
                //Debug.Log("liste " + merge�ndex + " " + MatchList.matchList.levelObjects[merge�ndex].Count);
                mergeEnabled = true;
                break;
            }
        }
        MergeEnabled();
    }

    public void MergeClick()
    {
        firstLevelObjects = MatchList.matchList.levelObjects[merge�ndex];
        ChangeMachine();
        MatchList.matchList.Match();
        MatchList.matchList.ClearList();
        MatchList.matchList.CheckGameObjects();
        ButtonClicked();
    }

    private void MergeEnabled()
    {
        if (mergeEnabled)
            transform.GetComponent<EnoughMoney>().CanInteract = true;
        else
            transform.GetComponent<EnoughMoney>().CanInteract = false;
    }

    private void ChangeMachine()
    {
        GameObject mergeMachine = firstLevelObjects[0];
        if (mergeMachine.transform.GetChild(0).GetComponent<ActiveMan>().levelIndex != 4)
        {
            mergeMachine.transform.GetChild(0).GetComponent<ActiveMan>().levelIndex += 1;
        }


        mergeMachine.transform.GetChild(0).GetComponent<ActiveMan>().LevelMan();
        int index = MatchList.matchList.gameObjects.IndexOf(mergeMachine);  // Aktif CM'lerde ka��nc� indiste oldu�unu buluyor

        for (int i = index + 1; i < MatchList.matchList.gameObjects.Count; i++)
        {
            MatchList.matchList.gameObjects[i].transform.GetChild(0)
                                   .GetComponent<ActiveMan>()
                                   .PreviousActiveChild();
        }
    }
}
