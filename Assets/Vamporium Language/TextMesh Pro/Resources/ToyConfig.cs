using UnityEngine;

namespace KrToys
{
    [CreateAssetMenu(fileName = "ToyConfig", menuName = "StaticData/ToyConfigSo")]
    public class ToyConfigSO : ScriptableObject
    {
        public ToyItem[] toys;
    
    }
}