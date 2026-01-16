using UnityEngine;

namespace KrToys
{
    public static class ToySaver
    {
        private const string ToyKey = "Toys"; 
        public static void SaveToy(string toyName)
        {
            string saved = PlayerPrefs.GetString(ToyKey, "");
            saved += toyName + ";";
            PlayerPrefs.SetString(ToyKey,saved);

        }

        public static string[] LoadToy()
        {
           string saved = PlayerPrefs.GetString(ToyKey, "");
           return saved.Split(";",  System.StringSplitOptions.RemoveEmptyEntries);
        }
    }
}   