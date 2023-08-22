using UnityEngine;

public class BallActivation : MonoBehaviour
{
    private GameObject obje;


    private void Start()
    {
        BallActive();
    }

    public void BallActive()
    {
        obje = BallListManager.ballListManager.BallList[0];
        BallListManager.ballListManager.BallList.Remove(obje);

        obje.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2.5f, this.transform.position.z);
        obje.SetActive(true);
        
        obje.transform.GetComponent<BallPrice>().BallMoney(transform.parent.GetComponent<ActiveMan>().levelIndex);
        obje.transform.GetComponent<BallParticleControl>().ParticleControl(transform.parent.GetComponent<ActiveMan>().levelIndex);

        BallListManager.ballListManager.BallList.Add(obje);
   
    }
}
