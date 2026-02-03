using UnityEngine;

namespace Lesson_OrderScripts
{
    public class DamagePlayer : MonoBehaviour
    {
        private IntValue Damage;

        public int PublicDamage => Damage.Value;


        [SerializeField] public HPPlayer hpPlayer;


        public void Init()
        {
            Damage = new IntValue(7);
        }

        public void RecountStats()
        {
            if (hpPlayer.PublicHP > 5) Damage.Value *= 2;
        }
    }
}