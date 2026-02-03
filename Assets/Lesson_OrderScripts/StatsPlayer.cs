using UnityEngine;

namespace Lesson_OrderScripts
{
    public class StatsPlayer : MonoBehaviour
    {
        public HPPlayer  hpPlayer;
        public DamagePlayer damagePlayer;

        private void Start()
        {
            hpPlayer.Init();
            damagePlayer.Init();
            
            
            hpPlayer.RecountStats();
            damagePlayer.RecountStats();
        }
    }
}