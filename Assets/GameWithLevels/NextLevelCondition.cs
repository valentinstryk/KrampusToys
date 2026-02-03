using System;
using UnityEngine;

namespace GameWithLevels
{
    public class NextLevelCondition : MonoBehaviour
    {
        public LevelController levelController;

        private void Start()
        {
             levelController = FindObjectOfType<LevelController>();
        }

        void OnTriggerEnter(Collider other)
        {
            levelController.GoToNextLevel();
        }
    }
}