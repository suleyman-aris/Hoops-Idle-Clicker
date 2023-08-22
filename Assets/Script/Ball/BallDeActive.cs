using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeActive : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            collision.gameObject.SetActive(false);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            collision.gameObject.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
