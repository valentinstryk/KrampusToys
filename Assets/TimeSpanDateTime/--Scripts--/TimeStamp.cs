using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace TimeSpanDateTime.__Scripts__
{
    public class TimeStamp : MonoBehaviour
    {
        public DateTime lastAction;
        public TimeSpan total = TimeSpan.FromSeconds(5);
        private TimeSpan remaining;
        public Button timer;
        public TextMeshProUGUI text;
        private bool _isStarted = false;

        void Start()
        {
            timer.onClick.AddListener(Cooldown);
        }

        void Cooldown()
        {
            _isStarted = true;
            lastAction = DateTime.UtcNow + total;
        }

        void LateUpdate()
        {
            if (!_isStarted) return;
            remaining = lastAction - DateTime.UtcNow;
            if (remaining.TotalSeconds < 0)
            {
                _isStarted = false;
                text.text = "TimeSpan";
                timer.interactable = true;
                return;
            }

            text.text = Math.Round(remaining.TotalSeconds, 0).ToString();
            timer.interactable = false;


        }
    }
}
