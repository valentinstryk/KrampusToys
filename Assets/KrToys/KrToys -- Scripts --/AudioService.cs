using UnityEngine;

namespace KrToys
{
    public class AudioService : MonoBehaviour
    {
        public AudioSource  audioSource;

        public void PlayCollectSound()
        {
            audioSource.Play();
        }
    }
}