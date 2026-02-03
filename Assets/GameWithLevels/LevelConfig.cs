using UnityEngine;

namespace GameWithLevels
{
    
    [CreateAssetMenu(fileName = "LevelConfig", menuName = "Levels/LevelConfig")]
    public class LevelConfig : ScriptableObject
    {
        public LevelView[] Levels; 
    }
}