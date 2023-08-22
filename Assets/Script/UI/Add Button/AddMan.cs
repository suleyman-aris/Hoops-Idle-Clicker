using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMan : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public void CheckGameObjects()
    {
        gameObjects = SpawnPoints.spawnPoints.SpawnList;
        int i;
        for (i = 0; i < gameObjects.Count; i++)
        {
            GameObject go = gameObjects[i];

            if (!go.activeSelf)
            {
                go.SetActive(true);
                break;
            }
        }

        if (i == gameObjects.Count - 1)
        {
            OtherFunction();          
        }
    }
    private void OtherFunction()
    {
        transform.GetComponent<EnoughMoney>().CanInteract = false;
    }
}
