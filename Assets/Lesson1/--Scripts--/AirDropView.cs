using DG.Tweening;
using UnityEngine;

namespace Lesson1.__Scripts__
{
    public class AirDropView : MonoBehaviour
    {
        public ParticleSystem smoke;
        public ParticleSystem collectParticle;
        public GameObject model;

        public void PlaySmoke()
        {
            smoke.gameObject.SetActive(true);
            smoke.Play();
        }


        public void PlayCollect()
        {
            model.transform.DOScale(Vector3.zero, 1f).SetEase(Ease.OutBounce).OnComplete(PlayCollectParticle);
        }

        public void PlayCollectParticle()
        {
            ParticleSystem newSpark =  Instantiate(collectParticle, gameObject.transform);
        }
    }
}