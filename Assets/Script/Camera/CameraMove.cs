using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public List<Transform> targetsPos;
    public float duration;

    private void Start()
    {
        ChangePos();
    }

    public void Move(Transform targetPos)
    {
        if (transform.position != targetPos.position)
        {
            transform.DOMove(targetPos.position, duration);
        }

    }

    public void ChangePos()
    {
        switch (ActiveSpawnCount.activeSpawn.activeCount)
        {
            case 1:
            case 2:
            case 3:
                Move(targetsPos[0]);
                break;

            case 4:
            case 5:
            case 6:
                Move(targetsPos[1]);
                break;

            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
                Move(targetsPos[2]);
                break;

            case 14:
            case 15:
            case 16:
                Move(targetsPos[3]);
                break;

            default:
                Debug.Log("Belirtilen þartlar dýþýnda bir deðer girildi.");
                break;
        }
        //if (ActiveSpawnCount.activeSpawn.activeCount > 3)
        //{
        //    Move(targetsPos[1]);
        //}
        //else if (ActiveSpawnCount.activeSpawn.activeCount > 0)
        //{
        //    Move(targetsPos[0]);
        //}

    }
}
