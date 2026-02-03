using Lesson_OrderScripts;
using UnityEngine;

public class HPPlayer : MonoBehaviour
{
    private IntValue HP;
    public int PublicHP => HP.Value;
 

    [SerializeField] private DamagePlayer damagePlayer;


    public void Init()
    {
        HP = new IntValue(6);
      
    }

    public void RecountStats()
    {
        if (damagePlayer.PublicDamage > 5) HP.Value *= 2;
    }
    
    
    
}