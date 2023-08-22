using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public static SpawnPoints spawnPoints;

    public List<GameObject> SpawnList;

    private void Awake()
    {
        spawnPoints = spawnPoints == null ? this : spawnPoints;
    }
}
