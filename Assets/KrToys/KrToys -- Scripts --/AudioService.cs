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
        public AudioSource audioSourceFx;
        public AudioSource audioSourceBg;
        public PickingToy pickingToy;
        public Button btnStart;
        public UIService userInterface;

        void Start()
        {
          // btnStart.onClick.AddListener(PlayBackGroundSound);
        }

        public void PlayCollectSound()
        {
            audioSourceFx.Play();
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
            audioSourceFx.clip = clip;
            audioSourceFx.Play();
        }

        public void PlayBackGroundSound()
        {
            audioSourceBg.clip = startSound;
            audioSourceBg.Play();
        }

        public void PlayWinGameSound()
        {
            audioSourceFx.clip = santaLaughter;
            audioSourceFx.Play();
            audioSourceBg.mute = true;
        }

        public void PlayLoseSound()
        {
            audioSourceFx.clip = devilLaugter;
            audioSourceFx.Play();
            audioSourceBg.mute = true;
        }
    }
}


public enum SoundType
{
    CollectItem = 0,
    WinGame = 1,
    OpenDoor = 2
}