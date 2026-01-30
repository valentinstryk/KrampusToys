using System;
using UnityEngine;

namespace TimeSpanDateTime.__Scripts__
{
    public static class DateSaver 
    {
        public static void SaveDate(DateTime dateTime)
        {
            PlayerPrefs.SetInt(dateTime.Day.ToString(), dateTime.Hour);
        }

        public static int LoadDate(DateTime dateTime)
        {
            return PlayerPrefs.GetInt(dateTime.Day.ToString(), dateTime.Hour);
        }
    }
}