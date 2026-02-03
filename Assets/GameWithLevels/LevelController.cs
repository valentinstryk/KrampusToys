using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameWithLevels
{
    public class LevelController : MonoBehaviour
    {
        public LevelConfig LevelConfig;
        public GameObject PlayerPrefab;
        public Button NextLevelButton;
        private int _levelIndex = 0;
        private int _displayIndex = 1;
        private LevelView _currentLevel;
        private GameObject _player;
        public UnityEvent<int> OnLevelChanged = new UnityEvent<int>();

        void Start()
        {
            GoToNextLevel();
        }

        void SpawnPlayer(Transform point)
        {
            _player = Instantiate(PlayerPrefab);
            _player.transform.position = point.position;
        }

        LevelView SpawnLevel(int index)
        {
            LevelView currentLevel = Instantiate(LevelConfig.Levels[_levelIndex % LevelConfig.Levels.Length],
                Vector3.zero, Quaternion.identity);
            return currentLevel;
        }

        private void OnEnable()
        {
            NextLevelButton.onClick.AddListener(GoToNextLevel);
        }

        public void GoToNextLevel()
        {
            if (_currentLevel != null) Destroy(_currentLevel.gameObject);
            _currentLevel = SpawnLevel(_levelIndex);
            if (_player == null) SpawnPlayer(_currentLevel.playerPos);
            _player.transform.position = _currentLevel.playerPos.position;

            OnLevelChanged.Invoke(_displayIndex);
            _levelIndex++;
            _displayIndex++;
        }
    }
}