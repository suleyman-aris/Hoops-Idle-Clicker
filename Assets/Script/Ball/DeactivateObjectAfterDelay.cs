using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjectAfterDelay : MonoBehaviour
{
    public float deactivationDelay = 0.5f;

    //private void OnEnable()
    //{
    //    Invoke("DeactivateObject", deactivationDelay);
    //}

    private void OnCollisionEnter(Collision collision)
    {
        Invoke("DeactivateObject", deactivationDelay);
    }

    private void DeactivateObject()
    {
        gameObject.SetActive(false);
    }
}
