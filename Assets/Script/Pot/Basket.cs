using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public GameObject confettiExplosion;
    private Transform confettiPos;

    private void Start()
    {
        //confettiExplosion = GameObject.FindGameObjectWithTag("Confetti").gameObject;
        confettiPos = GameObject.FindGameObjectWithTag("Pot_Hole").transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Basket") && other.GetComponent<JustOne>().one)
        {
            other.GetComponent<JustOne>().one = false;
            MoneyManager.moneyManager.InreaseTotalMoney(other.GetComponent<BallPrice>().price);

            GameObject confettiEffect = Instantiate(confettiExplosion, confettiPos.position, Quaternion.identity);

            //Time.timeScale = 0f;

            if (Application.platform == RuntimePlatform.Android)
            {
                Vibrator.Vibrate(50); 
            }
        }
    }

    //private void Update()
    //{
    //if (Input.GetMouseButtonDown(0))
    //{
    //    Time.timeScale = 1f;
    //}
    //}
}
