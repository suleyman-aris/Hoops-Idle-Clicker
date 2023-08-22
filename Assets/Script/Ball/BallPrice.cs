using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPrice : MonoBehaviour
{
    public float price;
    public int ballIndex;

    public void BallMoney(int ballLevel)
    {
        ballIndex = ballLevel;
        price = BasketMoney.basketMoney.floatList[ballLevel - 1];
    }
}
