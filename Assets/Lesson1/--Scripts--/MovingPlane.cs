using DG.Tweening;
using UnityEngine;

public class MovingPlane : MonoBehaviour
{
    public Transform pointStart;
    public Transform pointFinish;
    void Start()
    {
        gameObject.transform.position = pointStart.position;
        Move();
    }

    void Move()
    {
        gameObject.transform.DOMove(pointFinish.position, 10f).SetEase(Ease.Linear);
    }
}
