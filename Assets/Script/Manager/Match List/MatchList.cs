using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchList : MonoBehaviour
{
    public static MatchList matchList;
    public List<GameObject> gameObjects;
    public Dictionary<int, List<GameObject>> levelObjects;

    private GameObject mergeButton;

    private void Awake()
    {
        matchList = matchList == null ? this : matchList;
        mergeButton = GameObject.Find("Merge Man");
    }
    

    private void Start()
    {
        Match();
        CreateList();
        CheckGameObjects();
        mergeButton.GetComponent<MergeMachine>().ButtonClicked();
    }

    public void Match()
    {
        gameObjects = SpawnPoints.spawnPoints.SpawnList;
        gameObjects = gameObjects.FindAll(go => go.activeSelf);
    }

    public void CreateList()
    {
        levelObjects = new Dictionary<int, List<GameObject>>();
        for (int i = 1; i <= 4; i++)
        {
            levelObjects[i] = new List<GameObject>();
        }
    }
    public void ClearList()
    {
        for (int i = 1; i <= 4; i++)
        {
            levelObjects[i].Clear();
        }
    }
    public void CheckGameObjects()
    {
        foreach (GameObject go in gameObjects)
        {
            int childIndex = go.transform.GetChild(0).GetComponent<ActiveMan>().levelIndex ; 
            levelObjects[childIndex].Add(go);
        }
    }
}
