using System;
using UnityEngine;

namespace KrToys
{
    public class AudioService : MonoBehaviour
    {
        public AudioClip _collectItem;
        public AudioClip _winGame;
        
        
        public AudioSource audioSource;

        public void PlayCollectSound()
        {
            audioSource.Play();
        }

        public void PlaySound(SoundType soundType)
        {
            AudioClip currentClip = null;

            switch (soundType)
            {
                case SoundType.CollectItem:
                    currentClip = _collectItem;
                    break;
                case SoundType.WinGame:
                    currentClip = _winGame;
                    break;
            }

            audioSource.clip = currentClip;
            audioSource.Play();
        }
    }
}


public enum SoundType
{
    CollectItem = 0,
    WinGame = 1,
}