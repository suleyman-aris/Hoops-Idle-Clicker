using DG.Tweening;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    private Transform _ball; // Basketbol topu
    private Transform target; // Potanýn hedef noktasý
    public float duration = 2f;

    private void OnEnable()
    {
        _ball = this.transform;
        target = GameObject.FindGameObjectWithTag("Pot_Hole").transform;

        Jump();
    }

    private void Jump()
    {
        //_ball.DOJump(target.position, 3f, 1, duration).SetEase(Ease.OutQuad).OnComplete(() => gameObject.SetActive(false));
        //_ball.DOJump(target.position, 3f, 1, duration).SetEase(Ease.OutQuad);
        _ball.DOJump(target.position, 3f, 1, duration);

    }
}
