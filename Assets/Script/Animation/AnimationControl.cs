using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public float animationBetween;
    public float wait;
    public float _timer = 0;

    public bool order = false;

    private void OnEnable()
    {
        AnimBetween(1);
    }

    public void AnimBetween(int i)
    {
        int index = SpawnPoints.spawnPoints.SpawnList.IndexOf(transform.parent.gameObject);
        animationBetween =  (2.4f + index * 0.075f) / i;
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer < animationBetween)
        {
            this.GetComponent<Animator>().SetBool("isThrowing", true);
        }
        else if (_timer > animationBetween)
        {
            this.GetComponent<Animator>().SetBool("isThrowing", false);
            StartCoroutine(MyCoroutine());

            _timer = 0;
        }
    }
    
    private IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(wait);
        transform.GetChild(0).GetComponent<BallActivation>().BallActive();
    }
}
