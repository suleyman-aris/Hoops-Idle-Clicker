using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTap : MonoBehaviour
{
    private bool isTimerRunning;
    private float time;

    public float ballDuration;
    public int animationBetween;
    public float manWait;


    void Update()
    {
        if (isTimerRunning)
        {
            time += Time.deltaTime;
            if (time > 2.0f)
            {
                isTimerRunning = false;
                time = 3f;
            }
        }

        if (time == 3f)
        {
            ballDuration = 2f;
            animationBetween = 1;
            manWait = 0.6f;

            BallDuration(ballDuration);
            ManAnim(animationBetween);

        }
    }

    public void BallDuration(float ballDuration)
    {
        foreach (GameObject go in BallListManager.ballListManager.BallList)
        {
            go.GetComponent<BallJump>().duration = ballDuration;
        }        
    }

    public void ManAnim(int animationBetween)
    {
        foreach (GameObject go in SpawnPoints.spawnPoints.SpawnList)
        {
            go.transform.GetChild(0).GetComponent<AnimationControl>().AnimBetween(animationBetween);
        }
    }

    public void ManAnim1(float manWait)
    {
        //foreach (GameObject go in SpawnPoints.spawnPoints.SpawnList)
        //{
        //    go.transform.GetChild(0).GetComponent<AnimationControl>().wait = manWait;
        //}
    }

    public void TimerStart()
    {
        isTimerRunning = true;
        time = 0;
    }

}
