using DG.Tweening;
using Lesson1.__Scripts__;
using UnityEngine;

public class AirDropController : MonoBehaviour
{
    public PlayingView plane;
    public AirDropView prefabAirDrop;
    public Transform airDropGround;
    private AirDropView _newAirDrop;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Drop();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            CollectDrop();
        }
    }

    private void Drop()
    {
        plane.DisableNet();
        _newAirDrop = Instantiate(prefabAirDrop, plane.transform.position, Quaternion.identity);
        _newAirDrop.transform.DOMove(airDropGround.position, 2f).SetEase(Ease.Linear).OnComplete(PlaySmokeAirDrop);
    }

    private void CollectDrop()
    {
        _newAirDrop.PlayCollect();
    }
    
    private void PlaySmokeAirDrop()
    {
        _newAirDrop.PlaySmoke();
    }
}
