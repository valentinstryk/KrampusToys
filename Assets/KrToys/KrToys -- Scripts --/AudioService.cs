using System;
using System.Xml;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace KrToys
{
    public class AudioService : MonoBehaviour
    {
        public AudioClip _collectItem;
        public AudioClip _winGame;
        public AudioClip startSound;
        public AudioClip santaLaughter;
        public AudioClip devilLaugter; 
        public AudioSource audioSource;
        public AudioSource audioSource2;
        public PickingToy pickingToy;
        public Button btnStart;
        public UIService userInterface;
        
        void Start()
        {
            btnStart.onClick.AddListener(PlayBackGroundSound);
        }
        
        public void PlayCollectSound()
        {
            audioSource.Play();
        }

     /*   public void PlaySound(SoundType soundType)
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
*/
        public void PlayToySound(AudioClip clip)
        {
            AudioClip currentClip = null;
            _collectItem = clip;
            currentClip = _collectItem;
            audioSource.clip = currentClip;
            audioSource.Play();
        }
        
        public void PlayBackGroundSound()
        {
                audioSource2.clip = startSound;
                audioSource2.Play();
                
            }

        public void PlayWinGameSound()
        {
            audioSource.clip = santaLaughter;
            audioSource.Play();
            audioSource2.mute = true; 
        }

        public void PlayLoseSound()
        {
            audioSource.clip = devilLaugter;
            audioSource.Play();
            audioSource2.mute = true;
        }
        }
        
    }



public enum SoundType
{
    CollectItem = 0,
    WinGame = 1,
    OpenDoor = 2
}