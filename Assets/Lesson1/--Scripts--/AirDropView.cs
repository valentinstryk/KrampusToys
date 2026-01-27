using UnityEngine;

namespace Lesson1.__Scripts__
{
    public class AirDropView : MonoBehaviour
    {
        public ParticleSystem smoke;
        
        public void PlaySmoke()
        {
            smoke.Play();
        }
        
        
    }
}