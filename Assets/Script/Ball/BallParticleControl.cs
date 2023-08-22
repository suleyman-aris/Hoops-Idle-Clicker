using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallParticleControl : MonoBehaviour
{
    public int particleIndex;

    private void Start()
    {
        ParticleControl(transform.GetComponent<BallPrice>().ballIndex);
    }

    public void ParticleControl(int index)
    {
        particleIndex = index;
        if (particleIndex > 1)
        {
            transform.GetChild(particleIndex - 2).gameObject.SetActive(true);
        }

    }
}
