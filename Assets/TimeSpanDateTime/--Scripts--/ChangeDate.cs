using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TimeSpanDateTime.__Scripts__
{
    public class ChangeDate : MonoBehaviour
    {
        public Button btnDate;
        public DateTime DateDay;

        public DateTime DateHour;

        //  public TimeSpan TimeSkip;
        public TextMeshProUGUI calendar;

        void Start()
        {
            DateDay = DateTime.Today;
            DateHour = DateTime.UtcNow;
            btnDate.onClick.AddListener(ChangeDay);
            calendar.text = $"{DateDay.Day}.{DateDay.Month} and {DateHour.Hour} hours";
        }

        void ChangeDay()
        {
            DateDay = DateDay.AddDays(3);
            DateHour = DateHour.AddHours(10);
            calendar.text = $"{DateDay.Day}.{DateDay.Month} and {DateHour.Hour} hours";
        }
        
        
        
    }
}