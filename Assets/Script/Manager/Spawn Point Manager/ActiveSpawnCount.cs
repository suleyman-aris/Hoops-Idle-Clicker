using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveSpawnCount : MonoBehaviour
{
    public static ActiveSpawnCount activeSpawn;
    public int activeCount;

    private string activeMan;

    private void OnEnable()
    {
        activeSpawn = activeSpawn == null ? this : activeSpawn;
        activeMan = transform.name + SceneManager.GetActiveScene().buildIndex.ToString();
        SaveActive();
    }

    private void SaveActive()
    {
        
        if (PlayerPrefs.HasKey(activeMan))
        {
            activeCount = PlayerPrefs.GetInt(activeMan);
            Debug.Log("Active Man Count" + activeCount);
            for (int i = 0; i < activeCount; i++)
            {
                SpawnPoints.spawnPoints.SpawnList[i].SetActive(true);
                //SpawnPoints.spawnPoints.SpawnList[i].transform.GetChild(0).GetComponent<ActiveMan>().LevelMan();
            }
        }
    }



    public void ActivePoint()
    {
        activeCount = SpawnPoints.spawnPoints.SpawnList.Count(obj => obj.activeSelf);
        PlayerPrefs.SetInt(activeMan, activeCount);
    }


}
