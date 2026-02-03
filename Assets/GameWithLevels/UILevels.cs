using TMPro;
using UnityEngine;

namespace GameWithLevels
{
    public class UILevels : MonoBehaviour
    {
        public TextMeshProUGUI LevelTxt;
        public LevelController Controller;

        void Start()
        {
            Controller.OnLevelChanged.AddListener(UpdateUI);
        }

        void UpdateUI(int level)
        {
            LevelTxt.text = $"Level: {level}";
        }
        
    }
}