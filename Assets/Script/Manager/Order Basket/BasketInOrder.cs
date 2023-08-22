using UnityEngine;
using System.Collections;

public class BasketInOrder : MonoBehaviour
{
    public float BasketWait = 1f;
    int i;

    private void Start()
    {
        //OrderBasker();
    }

    public void OrderBasker()
    {
        for (i = 0; i < ActiveSpawnCount.activeSpawn.activeCount; i++)
        {
            SpawnPoints.spawnPoints.SpawnList[i].transform.GetChild(0).GetComponent<AnimationControl>().order = true;
        }

    }
}
