using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallListManager : MonoBehaviour
{
    public static BallListManager ballListManager;

    public List<GameObject> BallList;

    private void Awake()
    {
        ballListManager = ballListManager == null ? this : ballListManager;
    }
}
